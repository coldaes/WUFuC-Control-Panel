namespace WUFuC_Reloaded
{
    partial class interfacewindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interfacewindow));
            this.taskbarinfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.enblbutton = new System.Windows.Forms.Button();
            this.toptext = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.disblbutton = new System.Windows.Forms.Button();
            this.maintext = new System.Windows.Forms.Label();
            this.aboutbox = new System.Windows.Forms.PictureBox();
            this.abouttext1 = new System.Windows.Forms.Label();
            this.aboutver2 = new System.Windows.Forms.Label();
            this.aboutver1 = new System.Windows.Forms.Label();
            this.aboutlicense = new System.Windows.Forms.LinkLabel();
            this.aboutgithub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.aboutbox)).BeginInit();
            this.SuspendLayout();
            // 
            // taskbarinfo
            // 
            this.taskbarinfo.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.taskbarinfo.Icon = ((System.Drawing.Icon)(resources.GetObject("taskbarinfo.Icon")));
            this.taskbarinfo.Text = "WUFuC service is running";
            this.taskbarinfo.Visible = true;
            // 
            // enblbutton
            // 
            this.enblbutton.Image = ((System.Drawing.Image)(resources.GetObject("enblbutton.Image")));
            this.enblbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.enblbutton.Location = new System.Drawing.Point(144, 123);
            this.enblbutton.Name = "enblbutton";
            this.enblbutton.Size = new System.Drawing.Size(115, 23);
            this.enblbutton.TabIndex = 0;
            this.enblbutton.Text = "Enable WUFuC";
            this.enblbutton.UseVisualStyleBackColor = true;
            this.enblbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // toptext
            // 
            this.toptext.AutoSize = true;
            this.toptext.Location = new System.Drawing.Point(141, 21);
            this.toptext.Name = "toptext";
            this.toptext.Size = new System.Drawing.Size(192, 13);
            this.toptext.TabIndex = 1;
            this.toptext.Text = "Welcome to the WUFuC Control Panel!";
            this.toptext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toptext.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(144, 153);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(236, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // disblbutton
            // 
            this.disblbutton.Image = ((System.Drawing.Image)(resources.GetObject("disblbutton.Image")));
            this.disblbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disblbutton.Location = new System.Drawing.Point(265, 123);
            this.disblbutton.Name = "disblbutton";
            this.disblbutton.Size = new System.Drawing.Size(115, 23);
            this.disblbutton.TabIndex = 4;
            this.disblbutton.Text = "Disable WUFuC";
            this.disblbutton.UseVisualStyleBackColor = true;
            this.disblbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // maintext
            // 
            this.maintext.AutoEllipsis = true;
            this.maintext.AutoSize = true;
            this.maintext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maintext.Location = new System.Drawing.Point(141, 51);
            this.maintext.Name = "maintext";
            this.maintext.Size = new System.Drawing.Size(237, 39);
            this.maintext.TabIndex = 5;
            this.maintext.Text = "WUFuC allows you to continue installing updates\r\non Windows 7, 8 and 8.1 systems " +
    "with\r\nunsupported processors.";
            this.maintext.Click += new System.EventHandler(this.label2_Click);
            // 
            // aboutbox
            // 
            this.aboutbox.BackColor = System.Drawing.SystemColors.Menu;
            this.aboutbox.Image = ((System.Drawing.Image)(resources.GetObject("aboutbox.Image")));
            this.aboutbox.Location = new System.Drawing.Point(9, 12);
            this.aboutbox.Name = "aboutbox";
            this.aboutbox.Size = new System.Drawing.Size(126, 164);
            this.aboutbox.TabIndex = 6;
            this.aboutbox.TabStop = false;
            this.aboutbox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // abouttext1
            // 
            this.abouttext1.AutoSize = true;
            this.abouttext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abouttext1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.abouttext1.Location = new System.Drawing.Point(76, 39);
            this.abouttext1.Name = "abouttext1";
            this.abouttext1.Size = new System.Drawing.Size(50, 13);
            this.abouttext1.TabIndex = 7;
            this.abouttext1.Text = "WUFuC";
            this.abouttext1.Click += new System.EventHandler(this.label3_Click);
            // 
            // aboutver2
            // 
            this.aboutver2.AutoSize = true;
            this.aboutver2.Location = new System.Drawing.Point(12, 99);
            this.aboutver2.Name = "aboutver2";
            this.aboutver2.Size = new System.Drawing.Size(111, 26);
            this.aboutver2.TabIndex = 8;
            this.aboutver2.Text = "WUFuC Control Panel\r\nv1.2";
            this.aboutver2.Click += new System.EventHandler(this.label4_Click);
            // 
            // aboutver1
            // 
            this.aboutver1.AutoSize = true;
            this.aboutver1.Location = new System.Drawing.Point(12, 77);
            this.aboutver1.Name = "aboutver1";
            this.aboutver1.Size = new System.Drawing.Size(93, 13);
            this.aboutver1.TabIndex = 9;
            this.aboutver1.Text = "WUFuC v0.7.1.81";
            // 
            // aboutlicense
            // 
            this.aboutlicense.AutoSize = true;
            this.aboutlicense.Location = new System.Drawing.Point(6, 163);
            this.aboutlicense.Name = "aboutlicense";
            this.aboutlicense.Size = new System.Drawing.Size(65, 13);
            this.aboutlicense.TabIndex = 13;
            this.aboutlicense.TabStop = true;
            this.aboutlicense.Text = "view license";
            this.aboutlicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // aboutgithub
            // 
            this.aboutgithub.AutoSize = true;
            this.aboutgithub.Location = new System.Drawing.Point(6, 150);
            this.aboutgithub.Name = "aboutgithub";
            this.aboutgithub.Size = new System.Drawing.Size(63, 13);
            this.aboutgithub.TabIndex = 15;
            this.aboutgithub.TabStop = true;
            this.aboutgithub.Text = "github page";
            this.aboutgithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // interfacewindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(392, 188);
            this.Controls.Add(this.aboutgithub);
            this.Controls.Add(this.aboutlicense);
            this.Controls.Add(this.aboutver1);
            this.Controls.Add(this.aboutver2);
            this.Controls.Add(this.abouttext1);
            this.Controls.Add(this.aboutbox);
            this.Controls.Add(this.maintext);
            this.Controls.Add(this.disblbutton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.toptext);
            this.Controls.Add(this.enblbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(408, 227);
            this.MinimumSize = new System.Drawing.Size(408, 227);
            this.Name = "interfacewindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WUFuC Control Panel";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.aboutbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon taskbarinfo;
        private System.Windows.Forms.Button enblbutton;
        private System.Windows.Forms.Label toptext;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button disblbutton;
        private System.Windows.Forms.Label maintext;
        private System.Windows.Forms.PictureBox aboutbox;
        private System.Windows.Forms.Label abouttext1;
        private System.Windows.Forms.Label aboutver2;
        private System.Windows.Forms.Label aboutver1;
        private System.Windows.Forms.LinkLabel aboutlicense;
        private System.Windows.Forms.LinkLabel aboutgithub;
    }
}

