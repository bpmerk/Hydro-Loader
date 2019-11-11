namespace hydroLIB
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.buttonregRegister = new System.Windows.Forms.Button();
            this.buttonbklgin = new System.Windows.Forms.Button();
            this.textBoxregUsname = new System.Windows.Forms.TextBox();
            this.textBoxregPword = new System.Windows.Forms.TextBox();
            this.textBoxregEmail = new System.Windows.Forms.TextBox();
            this.textBoxregInv = new System.Windows.Forms.TextBox();
            this.labelregUsname = new System.Windows.Forms.Label();
            this.labelregPword = new System.Windows.Forms.Label();
            this.labelregEmail = new System.Windows.Forms.Label();
            this.labelregInv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonregRegister
            // 
            this.buttonregRegister.Location = new System.Drawing.Point(12, 181);
            this.buttonregRegister.Name = "buttonregRegister";
            this.buttonregRegister.Size = new System.Drawing.Size(85, 23);
            this.buttonregRegister.TabIndex = 0;
            this.buttonregRegister.Text = "register";
            this.buttonregRegister.UseVisualStyleBackColor = true;
            this.buttonregRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonbklgin
            // 
            this.buttonbklgin.Location = new System.Drawing.Point(170, 181);
            this.buttonbklgin.Name = "buttonbklgin";
            this.buttonbklgin.Size = new System.Drawing.Size(85, 23);
            this.buttonbklgin.TabIndex = 1;
            this.buttonbklgin.Text = "back to login";
            this.buttonbklgin.UseVisualStyleBackColor = true;
            this.buttonbklgin.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxregUsname
            // 
            this.textBoxregUsname.Location = new System.Drawing.Point(65, 27);
            this.textBoxregUsname.Name = "textBoxregUsname";
            this.textBoxregUsname.Size = new System.Drawing.Size(137, 20);
            this.textBoxregUsname.TabIndex = 2;
            // 
            // textBoxregPword
            // 
            this.textBoxregPword.Location = new System.Drawing.Point(65, 64);
            this.textBoxregPword.Name = "textBoxregPword";
            this.textBoxregPword.PasswordChar = '✘';
            this.textBoxregPword.Size = new System.Drawing.Size(137, 20);
            this.textBoxregPword.TabIndex = 3;
            // 
            // textBoxregEmail
            // 
            this.textBoxregEmail.Location = new System.Drawing.Point(65, 103);
            this.textBoxregEmail.Name = "textBoxregEmail";
            this.textBoxregEmail.Size = new System.Drawing.Size(137, 20);
            this.textBoxregEmail.TabIndex = 4;
            // 
            // textBoxregInv
            // 
            this.textBoxregInv.Location = new System.Drawing.Point(65, 155);
            this.textBoxregInv.Name = "textBoxregInv";
            this.textBoxregInv.PasswordChar = '✘';
            this.textBoxregInv.Size = new System.Drawing.Size(137, 20);
            this.textBoxregInv.TabIndex = 5;
            // 
            // labelregUsname
            // 
            this.labelregUsname.AutoSize = true;
            this.labelregUsname.Location = new System.Drawing.Point(62, 11);
            this.labelregUsname.Name = "labelregUsname";
            this.labelregUsname.Size = new System.Drawing.Size(55, 13);
            this.labelregUsname.TabIndex = 6;
            this.labelregUsname.Text = "Username";
            // 
            // labelregPword
            // 
            this.labelregPword.AutoSize = true;
            this.labelregPword.Location = new System.Drawing.Point(62, 50);
            this.labelregPword.Name = "labelregPword";
            this.labelregPword.Size = new System.Drawing.Size(52, 13);
            this.labelregPword.TabIndex = 7;
            this.labelregPword.Text = "password";
            // 
            // labelregEmail
            // 
            this.labelregEmail.AutoSize = true;
            this.labelregEmail.Location = new System.Drawing.Point(62, 87);
            this.labelregEmail.Name = "labelregEmail";
            this.labelregEmail.Size = new System.Drawing.Size(32, 13);
            this.labelregEmail.TabIndex = 8;
            this.labelregEmail.Text = "Email";
            // 
            // labelregInv
            // 
            this.labelregInv.AutoSize = true;
            this.labelregInv.Location = new System.Drawing.Point(62, 139);
            this.labelregInv.Name = "labelregInv";
            this.labelregInv.Size = new System.Drawing.Size(59, 13);
            this.labelregInv.TabIndex = 9;
            this.labelregInv.Text = "invite code";
            // 
            // Register
            // 
            this.AcceptButton = this.buttonregRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 216);
            this.Controls.Add(this.labelregInv);
            this.Controls.Add(this.labelregEmail);
            this.Controls.Add(this.labelregPword);
            this.Controls.Add(this.labelregUsname);
            this.Controls.Add(this.textBoxregInv);
            this.Controls.Add(this.textBoxregEmail);
            this.Controls.Add(this.textBoxregPword);
            this.Controls.Add(this.textBoxregUsname);
            this.Controls.Add(this.buttonbklgin);
            this.Controls.Add(this.buttonregRegister);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hydro Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonregRegister;
        private System.Windows.Forms.Button buttonbklgin;
        private System.Windows.Forms.TextBox textBoxregUsname;
        private System.Windows.Forms.TextBox textBoxregPword;
        private System.Windows.Forms.TextBox textBoxregEmail;
        private System.Windows.Forms.TextBox textBoxregInv;
        private System.Windows.Forms.Label labelregUsname;
        private System.Windows.Forms.Label labelregPword;
        private System.Windows.Forms.Label labelregEmail;
        private System.Windows.Forms.Label labelregInv;
    }
}

