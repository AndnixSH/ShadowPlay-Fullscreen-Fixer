# ShadowPlay Fullscreen Fixer

![](Image.png)

A simple tool that temporary fixes fullscreen bug for ShadowPlay and maybe other remote desktop softwares. I made this since 2016. It seems to have been fixed since Chrome 61.0.3163.100 or earlier. In 2022 I updated it because someone asked me for the link, so here you go: https://github.com/AndnixSH/ShadowPlay-Fullscreen-Fixer/releases

I haven't tried because I don't use ShadowPlay anymore

# How it works?
This tool opens a small invisible window on top-left corner that you can't see. The transparent is 99% and it is not visible for you. 0% does not fix the problem as the form will be completely hidden. You can click through the window, so it does not disturb you or annoy you. When you enable it, it will extract the .exe on %AppData%\Local\Invisible Form and execute from there

Enable auto fix on startup will add the .exe file at %appdata%\Microsoft\Windows\Start Menu\Programs\Startup.

The invisible form uses around 5 MB of RAM. Process name "Invisible Form" 

# How I discovered it
Discovered this while I was using Bandicam to open floating selection, so I replicated by opening invisible window in 99% transparent


You can disable the hardware acceleration in browser settings but it is not recommended!
