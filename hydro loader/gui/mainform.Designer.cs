namespace hydroLIB.gui
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBoxUsinfo = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label_IP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelHWID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelRank = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelExpi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAccName = new System.Windows.Forms.Label();
            this.buttonInject = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxUsinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUsinfo
            // 
            this.groupBoxUsinfo.Controls.Add(this.label10);
            this.groupBoxUsinfo.Controls.Add(this.label_IP);
            this.groupBoxUsinfo.Controls.Add(this.label8);
            this.groupBoxUsinfo.Controls.Add(this.labelHWID);
            this.groupBoxUsinfo.Controls.Add(this.label6);
            this.groupBoxUsinfo.Controls.Add(this.labelRank);
            this.groupBoxUsinfo.Controls.Add(this.label4);
            this.groupBoxUsinfo.Controls.Add(this.labelExpi);
            this.groupBoxUsinfo.Controls.Add(this.label2);
            this.groupBoxUsinfo.Controls.Add(this.labelAccName);
            this.groupBoxUsinfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUsinfo.Name = "groupBoxUsinfo";
            this.groupBoxUsinfo.Size = new System.Drawing.Size(200, 200);
            this.groupBoxUsinfo.TabIndex = 1;
            this.groupBoxUsinfo.TabStop = false;
            this.groupBoxUsinfo.Text = "User Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "NULL";
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(19, 143);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(23, 13);
            this.label_IP.TabIndex = 8;
            this.label_IP.Text = "IP :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "NULL";
            // 
            // labelHWID
            // 
            this.labelHWID.AutoSize = true;
            this.labelHWID.Location = new System.Drawing.Point(2, 115);
            this.labelHWID.Name = "labelHWID";
            this.labelHWID.Size = new System.Drawing.Size(43, 13);
            this.labelHWID.TabIndex = 6;
            this.labelHWID.Text = "HWID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "NULL";
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.Location = new System.Drawing.Point(6, 89);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(39, 13);
            this.labelRank.TabIndex = 4;
            this.labelRank.Text = "Rank :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NULL";
            // 
            // labelExpi
            // 
            this.labelExpi.AutoSize = true;
            this.labelExpi.Location = new System.Drawing.Point(4, 58);
            this.labelExpi.Name = "labelExpi";
            this.labelExpi.Size = new System.Drawing.Size(41, 13);
            this.labelExpi.TabIndex = 2;
            this.labelExpi.Text = "Expiry :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NULL";
            // 
            // labelAccName
            // 
            this.labelAccName.AutoSize = true;
            this.labelAccName.Location = new System.Drawing.Point(6, 30);
            this.labelAccName.Name = "labelAccName";
            this.labelAccName.Size = new System.Drawing.Size(82, 13);
            this.labelAccName.TabIndex = 0;
            this.labelAccName.Text = "Account name :";
            // 
            // buttonInject
            // 
            this.buttonInject.Location = new System.Drawing.Point(12, 230);
            this.buttonInject.Name = "buttonInject";
            this.buttonInject.Size = new System.Drawing.Size(200, 23);
            this.buttonInject.TabIndex = 9;
            this.buttonInject.Text = "Inject";
            this.buttonInject.UseVisualStyleBackColor = true;
            this.buttonInject.Click += new System.EventHandler(this.buttonInject_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonInject);
            this.Controls.Add(this.groupBoxUsinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hydro Loader";
            this.groupBoxUsinfo.ResumeLayout(false);
            this.groupBoxUsinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUsinfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelExpi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAccName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelHWID;
        private System.Windows.Forms.Button buttonInject;
        private System.Windows.Forms.Label label3;
    }
}