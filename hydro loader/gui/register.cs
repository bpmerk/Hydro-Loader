using System;
using System.Diagnostics;
using System.Windows.Forms;
using AuthGG;

namespace hydroLIB
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxregUsname.Text;           
            string password = textBoxregPword.Text;           
            string email = textBoxregEmail.Text;          
            string license = textBoxregInv.Text;

            bool register = AuthGG.Auth.Register(username, password, email, license, true);  
            if (register)
            {
                if (Auth.Response != AuthGG.Initialize.Secret)
                {
                    MessageBox.Show("An error occured!", "Hydro Loader");  //Hydro Loader can be changed 
                    Application.ExitThread();
                    Application.Exit();
                }                
            }
            else
            {              
                MessageBox.Show("Failed to register!", "hydro_loader Loader");  //Hydro Loader can be changed             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {    
            this.Hide();

            hydroLIB.gui.Login vs = new hydroLIB.gui.Login();
                vs.Show();  
        }
    }
}
/*____ _      _ _  ______________ _  _   
| __ ) _ __     _ __ ___ ___ _ __| | ___| || ||___ /___ / ___|| || |  
|  _ \| '_ \   | '_ ` _ \ / _ \ '__| |/ /_  ..  _||_ \ |_ \___ \| || |_ 
| |_) | |_) |  | | | | | |  __/ |  |   <|_ _|__) |__) |__) |__ _|
|____/| .__/___|_| |_| |_|\___|_|  |_|\_\ |_||_||____/____/____/   |_|  
      |_| |_____|       */                                                                                                     