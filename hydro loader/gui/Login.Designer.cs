namespace hydroLIB.gui
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRgister = new System.Windows.Forms.Button();
            this.txtBoxUsname = new System.Windows.Forms.TextBox();
            this.txtBoxPword = new System.Windows.Forms.TextBox();
            this.labelUsname = new System.Windows.Forms.Label();
            this.labelPword = new System.Windows.Forms.Label();
            this.chkBxRemember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 161);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRgister
            // 
            this.btnRgister.Location = new System.Drawing.Point(250, 161);
            this.btnRgister.Name = "btnRgister";
            this.btnRgister.Size = new System.Drawing.Size(75, 23);
            this.btnRgister.TabIndex = 1;
            this.btnRgister.Text = "Register";
            this.btnRgister.UseVisualStyleBackColor = true;
            this.btnRgister.Click += new System.EventHandler(this.btnRgister_Click);
            // 
            // txtBoxUsname
            // 
            this.txtBoxUsname.Location = new System.Drawing.Point(100, 49);
            this.txtBoxUsname.Name = "txtBoxUsname";
            this.txtBoxUsname.Size = new System.Drawing.Size(139, 20);
            this.txtBoxUsname.TabIndex = 2;
            // 
            // txtBoxPword
            // 
            this.txtBoxPword.Location = new System.Drawing.Point(100, 88);
            this.txtBoxPword.Name = "txtBoxPword";
            this.txtBoxPword.PasswordChar = '✘';
            this.txtBoxPword.Size = new System.Drawing.Size(139, 20);
            this.txtBoxPword.TabIndex = 3;
            // 
            // labelUsname
            // 
            this.labelUsname.AutoSize = true;
            this.labelUsname.Location = new System.Drawing.Point(97, 33);
            this.labelUsname.Name = "labelUsname";
            this.labelUsname.Size = new System.Drawing.Size(55, 13);
            this.labelUsname.TabIndex = 4;
            this.labelUsname.Text = "Username";
            // 
            // labelPword
            // 
            this.labelPword.AutoSize = true;
            this.labelPword.Location = new System.Drawing.Point(97, 72);
            this.labelPword.Name = "labelPword";
            this.labelPword.Size = new System.Drawing.Size(53, 13);
            this.labelPword.TabIndex = 5;
            this.labelPword.Text = "Password";
            // 
            // chkBxRemember
            // 
            this.chkBxRemember.AutoSize = true;
            this.chkBxRemember.Location = new System.Drawing.Point(116, 165);
            this.chkBxRemember.Name = "chkBxRemember";
            this.chkBxRemember.Size = new System.Drawing.Size(89, 17);
            this.chkBxRemember.TabIndex = 6;
            this.chkBxRemember.Text = "remember me";
            this.chkBxRemember.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 196);
            this.Controls.Add(this.chkBxRemember);
            this.Controls.Add(this.labelPword);
            this.Controls.Add(this.labelUsname);
            this.Controls.Add(this.txtBoxPword);
            this.Controls.Add(this.txtBoxUsname);
            this.Controls.Add(this.btnRgister);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hydro Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRgister;
        private System.Windows.Forms.TextBox txtBoxUsname;
        private System.Windows.Forms.TextBox txtBoxPword;
        private System.Windows.Forms.Label labelUsname;
        private System.Windows.Forms.Label labelPword;
        private System.Windows.Forms.CheckBox chkBxRemember;
    }
}