namespace VIdeoFreezeFix
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.enableFloat = new System.Windows.Forms.Button();
            this.disableFloat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addStartup = new System.Windows.Forms.Button();
            this.removeStartup = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblProcess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // enableFloat
            // 
            this.enableFloat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableFloat.Location = new System.Drawing.Point(111, 181);
            this.enableFloat.Name = "enableFloat";
            this.enableFloat.Size = new System.Drawing.Size(87, 33);
            this.enableFloat.TabIndex = 0;
            this.enableFloat.Text = "Enable";
            this.enableFloat.UseVisualStyleBackColor = true;
            this.enableFloat.Click += new System.EventHandler(this.enableFloat_Click);
            // 
            // disableFloat
            // 
            this.disableFloat.Enabled = false;
            this.disableFloat.Location = new System.Drawing.Point(243, 181);
            this.disableFloat.Name = "disableFloat";
            this.disableFloat.Size = new System.Drawing.Size(87, 33);
            this.disableFloat.TabIndex = 1;
            this.disableFloat.Text = "Disable";
            this.disableFloat.UseVisualStyleBackColor = true;
            this.disableFloat.Click += new System.EventHandler(this.disableBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(11, 379);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(75, 23);
            this.aboutBtn.TabIndex = 4;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(128, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 42);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "This tool will add the .exe file into the startup folder under\r\n%appdata%\\Microso" +
    "ft\\Windows\\Start Menu\\Programs\\Startup ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temporary fix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Auto fix on startup";
            // 
            // addStartup
            // 
            this.addStartup.Location = new System.Drawing.Point(78, 333);
            this.addStartup.Name = "addStartup";
            this.addStartup.Size = new System.Drawing.Size(120, 23);
            this.addStartup.TabIndex = 2;
            this.addStartup.Text = "Add .exe on startup";
            this.addStartup.UseVisualStyleBackColor = true;
            this.addStartup.Click += new System.EventHandler(this.addStartup_Click);
            // 
            // removeStartup
            // 
            this.removeStartup.Location = new System.Drawing.Point(243, 333);
            this.removeStartup.Name = "removeStartup";
            this.removeStartup.Size = new System.Drawing.Size(136, 23);
            this.removeStartup.TabIndex = 3;
            this.removeStartup.Text = "Remove .exe from startup";
            this.removeStartup.UseVisualStyleBackColor = true;
            this.removeStartup.Click += new System.EventHandler(this.removeStartup_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(370, 379);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblProcess.Location = new System.Drawing.Point(131, 229);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(194, 13);
            this.lblProcess.TabIndex = 3;
            this.lblProcess.Text = "The process \"Invisible Form\" is running!";
            this.lblProcess.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "V1.0.2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.removeStartup);
            this.Controls.Add(this.addStartup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disableFloat);
            this.Controls.Add(this.enableFloat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShadowPlay Fullscreen fixer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enableFloat;
        private System.Windows.Forms.Button disableFloat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addStartup;
        private System.Windows.Forms.Button removeStartup;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label label2;
    }
}

