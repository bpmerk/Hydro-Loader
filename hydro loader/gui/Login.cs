using System;
using System.Diagnostics;
using System.Windows.Forms;
using AuthGG;
using hydro_loader.Properties;
/// <summary>
///                                                     Instructions are in the code!!!!
/// </summary>
namespace hydroLIB.gui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            HashCheck.HashChecks();
            if (HashCheck.isValidDLL)
            {
                AuthGG.Initialize.AID = "618613"; //set your AID here found on top left of your panel!
                AuthGG.Initialize.Version = "1.0";  //program version!
                AuthGG.Initialize.Secret = "mDzgdfhdfhdrhdrh"; //Any random string you want! (make sure to change this!)
                AuthGG.Initialize.Init();
            }
            else
            {
                MessageBox.Show("Hashcheck has failed!");
                Process.GetCurrentProcess().Kill();
            }
            /*bool freemode = AuthGG.Auth.Freemode();    // working on this will be added fully in a future update!
            if (freemode)
            {
                if (Auth.Response != AuthGG.Initialize.Secret)
                {
                    MessageBox.Show("An error occured!", "Hydro Loader"); //stops them from bypassing dll returning true;
                    Process.GetCurrentProcess().Kill();
                }
                MessageBox.Show("Free Weekend Now Active For All Users!");
                

            }*/
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtBoxUsname.Text = Settings.Default["usernameValue"].ToString();
            txtBoxPword.Text = Settings.Default["passwordValue"].ToString();
            if (Settings.Default["chkBxStatus"].ToString() == "True")
                chkBxRemember.Checked = true;
            else
                chkBxRemember.Checked = false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (chkBxRemember.Checked)  // dont touch this! this is for the remember login
            {
                Settings.Default["usernameValue"] = txtBoxUsname.Text; ;
                Settings.Default["passwordValue"] = txtBoxPword.Text;
                Settings.Default["chkBxStatus"] = "True";
                Settings.Default.Save();
            }
            else
            {
                Settings.Default["passwordValue"] = "";
                Settings.Default["usernameValue"] = "";
                Settings.Default["chkBxStatus"] = "false";
                Settings.Default.Save();
            }
            string username = txtBoxUsname.Text;
            string password = txtBoxPword.Text;

            bool login = AuthGG.Auth.Login(username, password, true); 
            if (login)
            {
                if (Auth.Response != AuthGG.Initialize.Secret)
                {
                    MessageBox.Show("An error occured!", "Hydro Loader");  //hydro loader can be changed to your program name! shows as a header in messagebox!
                    Process.GetCurrentProcess().Kill();
                }               
                AuthGG.Log.LogAction("Login Successful");              
                Form3 vs = new Form3();
                Hide();
                vs.Show();
            }
        }
        private void btnRgister_Click(object sender, EventArgs e)
        {           
            Register vd = new Register();
            Hide();
            vd.Show();
        }       
    }


    /// Made by: Bp_merk#3354 (AKA Shalissa)
    /// auth used: Auth.gg
    /// injection lib: hydroLIB
    /// AES encryption
    /// Byte array injecton with manual map
    /// setup for csgo but can be used on any game!
    /*____ _      _ _  ______________ _  _   
    | __ ) _ __     _ __ ___ ___ _ __| | ___| || ||___ /___ / ___|| || |  
    |  _ \| '_ \   | '_ ` _ \ / _ \ '__| |/ /_  ..  _||_ \ |_ \___ \| || |_ 
    | |_) | |_) |  | | | | | |  __/ |  |   <|_ _|__) |__) |__) |__ _|
    |____/| .__/___|_| |_| |_|\___|_|  |_|\_\ |_||_||____/____/____/   |_|  
          |_| |_____|       */

}