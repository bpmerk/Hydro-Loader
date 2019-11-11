using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuthGG;
using hydro_loader;
using ManualMapInjection.Injection;

namespace hydroLIB.gui
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            string ExpiryDateTime = UserInfo.Expiry.ToString();  //all user info
            string ExpiryDate = ExpiryDateTime.Substring(0, (ExpiryDateTime.Length - 8));
            label2.Text = UserInfo.Username;
            label4.Text = (ExpiryDate);
            label6.Text = UserInfo.Rank.ToString();
            label8.Text = UserInfo.HWID;
            label10.Text = UserInfo.IP;          
        }
        private void Form1_Load(object sender, EventArgs e)
        {         
        }      
        private void label3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
        private async void buttonInject_Click(object sender, EventArgs e)
        {
            Process[] processStarted = Process.GetProcessesByName("csgo");//process name
            if (processStarted.Length == 0)
            {
                Process.Start("steam:rungameid/730");// steam game id
                await Task.Delay(20000);
            }
            else
            {
                Inject();
            }
            void Inject()
            {
                WebClient wc = new WebClient();
                wc.Credentials = new NetworkCredential(Var.FTPU, Var.FTPP); //ftp username and password as variables. (found in Variables.cs in classes folder)
                wc.DownloadFile(files.Location, files.path);// variables for dll path and save location. (found in files.cs in classes folder)
                FileDecrypt(files.path, files.path2, files.Pword);// variables to decrypt dll
                byte[] buffer = File.ReadAllBytes(files.path2);// path to save the dycrypted dll and read the bytes (found in files.cs in classes folder)            
                Process process = Process.GetProcessesByName("csgo").FirstOrDefault<Process>();//add your process name
                ManualMapInjector manualMapInjector = new ManualMapInjector(process)
                {
                    AsyncInjection = true
                };
                bool flag = process != null;
                if (flag)
                {
                    string text = string.Format("hmodule = 0x{0:x8}", manualMapInjector.Inject(buffer).ToInt32());// 
                    File.Delete(files.path);
                    File.Delete(files.path2);
                    MessageBox.Show("Injected, Hydro Loader");// hydro loader can be changed to your program name
                    base.Close();                    
                    Environment.Exit(0);
                    Application.Exit();
                }
            }
        }
        public static void FileDecrypt(string inputFile, string outputFile, string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] array = new byte[32];
            FileStream fileStream = new FileStream(inputFile, FileMode.Open);
            fileStream.Read(array, 0, array.Length);
            RijndaelManaged rijndaelManaged = new RijndaelManaged();
            rijndaelManaged.KeySize = 256;
            rijndaelManaged.BlockSize = 128;
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
            rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
            rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
            rijndaelManaged.Padding = PaddingMode.PKCS7;
            rijndaelManaged.Mode = CipherMode.CFB;
            CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
            FileStream fileStream2 = new FileStream(outputFile, FileMode.Create);
            byte[] array2 = new byte[1048576];
            try
            {
                int count;
                while ((count = cryptoStream.Read(array2, 0, array2.Length)) > 0)
                {
                    Application.DoEvents();
                    fileStream2.Write(array2, 0, count);
                }
            }
            catch (CryptographicException)
            {              
            }
            try
            {
                cryptoStream.Close();
            }
            catch (Exception)
            {               
            }
            finally
            {
                fileStream2.Close();
                fileStream.Close();
            }

            MessageBox.Show("  All files done! \n Continuing with injection ", "Hydro Loader");// hydro loader can be changed to your program name
        }
    }  
}
/*____ _      _ _  ______________ _  _   
| __ ) _ __     _ __ ___ ___ _ __| | ___| || ||___ /___ / ___|| || |  
|  _ \| '_ \   | '_ ` _ \ / _ \ '__| |/ /_  ..  _||_ \ |_ \___ \| || |_ 
| |_) | |_) |  | | | | | |  __/ |  |   <|_ _|__) |__) |__) |__ _|
|____/| .__/___|_| |_| |_|\___|_|  |_|\_\ |_||_||____/____/____/   |_|  
      |_| |_____|       */
