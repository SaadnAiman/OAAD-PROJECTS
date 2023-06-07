namespace MyStore
{
    partial class CreateUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UMale = new System.Windows.Forms.RadioButton();
            this.UFemale = new System.Windows.Forms.RadioButton();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblmobile = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.UAddress = new System.Windows.Forms.TextBox();
            this.UMobile = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.UEmail = new System.Windows.Forms.TextBox();
            this.jnclbl = new System.Windows.Forms.Label();
            this.UNametxt = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.lblmobile);
            this.panel1.Controls.Add(this.lbladdress);
            this.panel1.Controls.Add(this.UAddress);
            this.panel1.Controls.Add(this.UMobile);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.UEmail);
            this.panel1.Controls.Add(this.jnclbl);
            this.panel1.Controls.Add(this.UNametxt);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 373);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyStore.Properties.Resources.IMG_2203;
            this.pictureBox1.InitialImage = global::MyStore.Properties.Resources.IMG_2203;
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UMale);
            this.groupBox1.Controls.Add(this.UFemale);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(122, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 33);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // UMale
            // 
            this.UMale.AutoSize = true;
            this.UMale.Location = new System.Drawing.Point(6, 10);
            this.UMale.Name = "UMale";
            this.UMale.Size = new System.Drawing.Size(50, 19);
            this.UMale.TabIndex = 1;
            this.UMale.TabStop = true;
            this.UMale.Text = "Male";
            this.UMale.UseVisualStyleBackColor = true;
            // 
            // UFemale
            // 
            this.UFemale.AutoSize = true;
            this.UFemale.Location = new System.Drawing.Point(104, 10);
            this.UFemale.Name = "UFemale";
            this.UFemale.Size = new System.Drawing.Size(59, 19);
            this.UFemale.TabIndex = 0;
            this.UFemale.TabStop = true;
            this.UFemale.Text = "Female";
            this.UFemale.UseVisualStyleBackColor = true;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(27, 172);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(57, 19);
            this.lblgender.TabIndex = 12;
            this.lblgender.Text = "Gender";
            // 
            // lblmobile
            // 
            this.lblmobile.AutoSize = true;
            this.lblmobile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobile.Location = new System.Drawing.Point(27, 209);
            this.lblmobile.Name = "lblmobile";
            this.lblmobile.Size = new System.Drawing.Size(53, 19);
            this.lblmobile.TabIndex = 11;
            this.lblmobile.Text = "Mobile";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(27, 247);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(59, 19);
            this.lbladdress.TabIndex = 10;
            this.lbladdress.Text = "Address";
            // 
            // UAddress
            // 
            this.UAddress.Location = new System.Drawing.Point(122, 249);
            this.UAddress.Multiline = true;
            this.UAddress.Name = "UAddress";
            this.UAddress.Size = new System.Drawing.Size(163, 60);
            this.UAddress.TabIndex = 9;
            // 
            // UMobile
            // 
            this.UMobile.Location = new System.Drawing.Point(122, 204);
            this.UMobile.Multiline = true;
            this.UMobile.Name = "UMobile";
            this.UMobile.Size = new System.Drawing.Size(163, 25);
            this.UMobile.TabIndex = 8;
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(31, 330);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(111, 28);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(174, 330);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(111, 28);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // UEmail
            // 
            this.UEmail.Location = new System.Drawing.Point(122, 127);
            this.UEmail.Multiline = true;
            this.UEmail.Name = "UEmail";
            this.UEmail.Size = new System.Drawing.Size(163, 25);
            this.UEmail.TabIndex = 5;
            // 
            // jnclbl
            // 
            this.jnclbl.AutoSize = true;
            this.jnclbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jnclbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.jnclbl.Location = new System.Drawing.Point(90, 21);
            this.jnclbl.Name = "jnclbl";
            this.jnclbl.Size = new System.Drawing.Size(220, 36);
            this.jnclbl.TabIndex = 4;
            this.jnclbl.Text = "jewels.n.Crafts";
            this.jnclbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // UNametxt
            // 
            this.UNametxt.Location = new System.Drawing.Point(122, 83);
            this.UNametxt.Multiline = true;
            this.UNametxt.Name = "UNametxt";
            this.UNametxt.Size = new System.Drawing.Size(163, 25);
            this.UNametxt.TabIndex = 2;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(27, 132);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(47, 19);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "Email";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(27, 88);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(47, 19);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 375);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(333, 414);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.Load += new System.EventHandler(this.CreateUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblmobile;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox UAddress;
        private System.Windows.Forms.TextBox UMobile;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox UEmail;
        private System.Windows.Forms.Label jnclbl;
        private System.Windows.Forms.TextBox UNametxt;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.RadioButton UMale;
        private System.Windows.Forms.RadioButton UFemale;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}