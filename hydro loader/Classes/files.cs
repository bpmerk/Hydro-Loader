using System;
using System.Net;
using AuthGG;
using hydro_loader;
using hydroLIB;
namespace hydro_loader
{
    public class files
    {
        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\\ExitAPI.dll.ENC";
        public static string Location = Auth.GetVariable("3DPCtk1XNf4mHcEgVlWuEZvtbFNaI");// dll on ftp variable Example:https://yourwebsite/FTP/yourDllHere.dll.ENC
        public static string Pword = Auth.GetVariable("B9ySIrcN7F4ovXLjw5vEtAxklCzwa");// variable for encryption key(key you created when you encrypted your dll with file encryptor.exe)
        public static string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\ExitAPI.dll";
    }
}
