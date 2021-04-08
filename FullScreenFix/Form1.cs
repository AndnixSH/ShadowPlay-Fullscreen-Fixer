using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace VIdeoFreezeFix
{
    public partial class Form1 : Form
    {
        // path of startup folder
        string startuppath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\Start Menu\Programs\Startup";
        // add exe file in local appdata
        string docspath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Invisible Form";
        byte[] file1 = FullscreenFixer.Properties.Resources.Invisible_Form;
        public Form1()
        {
            InitializeComponent();
            // check if file exists
            if (File.Exists(startuppath + @"\Invisible Form.exe"))
            {
                addStartup.Enabled = false;
                removeStartup.Enabled = true;
            }
            if (!File.Exists(startuppath + @"\Invisible Form.exe"))
            {
                addStartup.Enabled = true;
                removeStartup.Enabled = false;
            }
            // get process name "Invisible Form"
            foreach (var process in Process.GetProcessesByName("Invisible Form"))
            {
                enableFloat.Enabled = false;
                disableFloat.Enabled = true;
                removeStartup.Enabled = false;
                lblProcess.Visible = true;
            }
        }
        // enable button
        private void enableFloat_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(docspath))
            {
                Directory.CreateDirectory(docspath);
            }
            
            File.WriteAllBytes(docspath + @"\Invisible Form.exe", file1);
            System.Diagnostics.Process.Start(docspath + @"\Invisible Form.exe");
            enableFloat.Enabled = false;
            disableFloat.Enabled = true;
            lblProcess.Visible = true;
            removeStartup.Enabled = false;
        }
        // disable button
        private void disableBtn_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("Invisible Form"))
            {
                process.Kill();
                enableFloat.Enabled = true;
                disableFloat.Enabled = false;
                lblProcess.Visible = false;
                if (File.Exists(startuppath + @"\Invisible Form.exe"))
                {
                    removeStartup.Enabled = true;
                }
            }
        }
        // add file in startup
        private void addStartup_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(startuppath))
            {
                try
                {
                    File.WriteAllBytes(startuppath + @"\Invisible Form.exe", file1);
                    MessageBox.Show("Added!");
                    addStartup.Enabled = false;
                    removeStartup.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("There was an error adding the file into startup folder. Please run the tool as administrator and try again");
            }
        }
        // remove file from startup
        private void removeStartup_Click(object sender, EventArgs e)
        {
            if (File.Exists(startuppath + @"\Invisible Form.exe"))
            {
                File.Delete(startuppath + @"\Invisible Form.exe");
                MessageBox.Show("Removed!");
                addStartup.Enabled = true;
                removeStartup.Enabled = false;
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }
        // about
        private void aboutBtn_Click(object sender, EventArgs e)
        {
            About aform = new About();
            aform.Show();
        }
        // exit
        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
