namespace WindowsFormsApp5
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbtt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.usernametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 476);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(67, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to ERASMUS+ App!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginbtt
            // 
            this.loginbtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loginbtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtt.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtt.Location = new System.Drawing.Point(170, 351);
            this.loginbtt.Name = "loginbtt";
            this.loginbtt.Size = new System.Drawing.Size(106, 37);
            this.loginbtt.TabIndex = 6;
            this.loginbtt.Text = "Sing in";
            this.loginbtt.UseVisualStyleBackColor = false;
            this.loginbtt.Click += new System.EventHandler(this.loginbtt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(37, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wrong username or password";
            this.label3.Visible = false;
            // 
            // usernametxt
            // 
            this.usernametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usernametxt.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usernametxt.HintText = "";
            this.usernametxt.isPassword = false;
            this.usernametxt.LineFocusedColor = System.Drawing.Color.Red;
            this.usernametxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.usernametxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.usernametxt.LineThickness = 4;
            this.usernametxt.Location = new System.Drawing.Point(73, 223);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(4);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(306, 33);
            this.usernametxt.TabIndex = 11;
            this.usernametxt.Text = "Username";
            this.usernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passtxt
            // 
            this.passtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passtxt.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passtxt.HintText = "";
            this.passtxt.isPassword = true;
            this.passtxt.LineFocusedColor = System.Drawing.Color.Red;
            this.passtxt.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passtxt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.passtxt.LineThickness = 4;
            this.passtxt.Location = new System.Drawing.Point(73, 278);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(306, 33);
            this.passtxt.TabIndex = 12;
            this.passtxt.Text = "Username";
            this.passtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 0;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(420, -10);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(56, 52);
            this.bunifuTileButton1.TabIndex = 13;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(471, 616);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginbtt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbtt;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernametxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passtxt;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.Timer timer1;
    }
}

