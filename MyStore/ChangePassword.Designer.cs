namespace MyStore
{
    partial class ChangePassword
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
            this.lbloldpass = new System.Windows.Forms.Label();
            this.oldpasstxt = new System.Windows.Forms.TextBox();
            this.jnclbl = new System.Windows.Forms.Label();
            this.lblnpass = new System.Windows.Forms.Label();
            this.lblnewpass = new System.Windows.Forms.Label();
            this.newpasstxt = new System.Windows.Forms.TextBox();
            this.rtpasstxt = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbloldpass
            // 
            this.lbloldpass.AutoSize = true;
            this.lbloldpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloldpass.Location = new System.Drawing.Point(8, 86);
            this.lbloldpass.Name = "lbloldpass";
            this.lbloldpass.Size = new System.Drawing.Size(96, 19);
            this.lbloldpass.TabIndex = 1;
            this.lbloldpass.Text = "Old Password";
            this.lbloldpass.Click += new System.EventHandler(this.label1_Click);
            // 
            // oldpasstxt
            // 
            this.oldpasstxt.Location = new System.Drawing.Point(129, 81);
            this.oldpasstxt.Multiline = true;
            this.oldpasstxt.Name = "oldpasstxt";
            this.oldpasstxt.Size = new System.Drawing.Size(192, 25);
            this.oldpasstxt.TabIndex = 3;
            // 
            // jnclbl
            // 
            this.jnclbl.AutoSize = true;
            this.jnclbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jnclbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.jnclbl.Location = new System.Drawing.Point(101, 18);
            this.jnclbl.Name = "jnclbl";
            this.jnclbl.Size = new System.Drawing.Size(220, 36);
            this.jnclbl.TabIndex = 6;
            this.jnclbl.Text = "jewels.n.Crafts";
            // 
            // lblnpass
            // 
            this.lblnpass.AutoSize = true;
            this.lblnpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnpass.Location = new System.Drawing.Point(8, 167);
            this.lblnpass.Name = "lblnpass";
            this.lblnpass.Size = new System.Drawing.Size(116, 19);
            this.lblnpass.TabIndex = 7;
            this.lblnpass.Text = "Retype Password";
            // 
            // lblnewpass
            // 
            this.lblnewpass.AutoSize = true;
            this.lblnewpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpass.Location = new System.Drawing.Point(8, 126);
            this.lblnewpass.Name = "lblnewpass";
            this.lblnewpass.Size = new System.Drawing.Size(103, 19);
            this.lblnewpass.TabIndex = 8;
            this.lblnewpass.Text = "New Password";
            // 
            // newpasstxt
            // 
            this.newpasstxt.Location = new System.Drawing.Point(129, 121);
            this.newpasstxt.Multiline = true;
            this.newpasstxt.Name = "newpasstxt";
            this.newpasstxt.Size = new System.Drawing.Size(192, 25);
            this.newpasstxt.TabIndex = 9;
            // 
            // rtpasstxt
            // 
            this.rtpasstxt.Location = new System.Drawing.Point(129, 162);
            this.rtpasstxt.Multiline = true;
            this.rtpasstxt.Name = "rtpasstxt";
            this.rtpasstxt.Size = new System.Drawing.Size(192, 25);
            this.rtpasstxt.TabIndex = 10;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.Location = new System.Drawing.Point(201, 212);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(111, 28);
            this.btnsubmit.TabIndex = 11;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(54, 212);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(111, 28);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyStore.Properties.Resources.IMG_2203;
            this.pictureBox1.InitialImage = global::MyStore.Properties.Resources.IMG_2203;
            this.pictureBox1.Location = new System.Drawing.Point(31, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(339, 263);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.rtpasstxt);
            this.Controls.Add(this.newpasstxt);
            this.Controls.Add(this.lblnewpass);
            this.Controls.Add(this.lblnpass);
            this.Controls.Add(this.jnclbl);
            this.Controls.Add(this.oldpasstxt);
            this.Controls.Add(this.lbloldpass);
            this.MaximumSize = new System.Drawing.Size(355, 302);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloldpass;
        private System.Windows.Forms.TextBox oldpasstxt;
        private System.Windows.Forms.Label jnclbl;
        private System.Windows.Forms.Label lblnpass;
        private System.Windows.Forms.Label lblnewpass;
        private System.Windows.Forms.TextBox newpasstxt;
        private System.Windows.Forms.TextBox rtpasstxt;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}