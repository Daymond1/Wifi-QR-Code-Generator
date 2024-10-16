namespace Wifi_QR_Code_Generator
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            nightForm1 = new ReaLTaiizor.Forms.NightForm();
            TextBoxPassword = new ReaLTaiizor.Controls.ForeverTextBox();
            nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            spaceMinimize1 = new ReaLTaiizor.Controls.SpaceMinimize();
            spaceClose1 = new ReaLTaiizor.Controls.SpaceClose();
            CopyPasswd = new ReaLTaiizor.Controls.NightButton();
            ShowPassword = new ReaLTaiizor.Controls.NightButton();
            pictureBoxQr = new PictureBox();
            SSIDlist = new ListBox();
            nightLinkLabel1 = new ReaLTaiizor.Controls.NightLinkLabel();
            nightForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQr).BeginInit();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightForm1.BackColor = Color.FromArgb(40, 48, 51);
            nightForm1.Controls.Add(nightLinkLabel1);
            nightForm1.Controls.Add(TextBoxPassword);
            nightForm1.Controls.Add(nightLabel2);
            nightForm1.Controls.Add(nightLabel1);
            nightForm1.Controls.Add(spaceMinimize1);
            nightForm1.Controls.Add(spaceClose1);
            nightForm1.Controls.Add(CopyPasswd);
            nightForm1.Controls.Add(ShowPassword);
            nightForm1.Controls.Add(pictureBoxQr);
            nightForm1.Controls.Add(SSIDlist);
            nightForm1.DrawIcon = false;
            nightForm1.Font = new Font("Segoe UI", 9F);
            nightForm1.HeadColor = Color.FromArgb(50, 58, 61);
            nightForm1.Location = new Point(0, -2);
            nightForm1.MinimumSize = new Size(100, 42);
            nightForm1.Name = "nightForm1";
            nightForm1.Padding = new Padding(0, 31, 0, 0);
            nightForm1.Size = new Size(555, 499);
            nightForm1.TabIndex = 0;
            nightForm1.Text = "Wifi QR Code Generator";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            nightForm1.Click += nightForm1_Click;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.BackColor = Color.Transparent;
            TextBoxPassword.BaseColor = Color.FromArgb(45, 47, 49);
            TextBoxPassword.BorderColor = Color.FromArgb(35, 168, 109);
            TextBoxPassword.FocusOnHover = false;
            TextBoxPassword.ForeColor = Color.FromArgb(192, 192, 192);
            TextBoxPassword.Location = new Point(297, 435);
            TextBoxPassword.MaxLength = 32767;
            TextBoxPassword.Multiline = false;
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.ReadOnly = true;
            TextBoxPassword.Size = new Size(225, 29);
            TextBoxPassword.TabIndex = 12;
            TextBoxPassword.TextAlign = HorizontalAlignment.Left;
            TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // nightLabel2
            // 
            nightLabel2.AutoSize = true;
            nightLabel2.BackColor = Color.Transparent;
            nightLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nightLabel2.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel2.Location = new Point(369, 39);
            nightLabel2.Name = "nightLabel2";
            nightLabel2.Size = new Size(72, 21);
            nightLabel2.TabIndex = 10;
            nightLabel2.Text = "QR Code";
            // 
            // nightLabel1
            // 
            nightLabel1.AutoSize = true;
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nightLabel1.ForeColor = Color.FromArgb(114, 118, 127);
            nightLabel1.Location = new Point(75, 39);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(97, 21);
            nightLabel1.TabIndex = 9;
            nightLabel1.Text = "WiFi Profiles";
            // 
            // spaceMinimize1
            // 
            spaceMinimize1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spaceMinimize1.Customization = "G4qM/3LEtP8yMjL/Kioq/yPJzP8bioz//v7+/yMjI/8qKir/";
            spaceMinimize1.DefaultAnchor = true;
            spaceMinimize1.DefaultLocation = true;
            spaceMinimize1.Font = new Font("Verdana", 8F);
            spaceMinimize1.Image = null;
            spaceMinimize1.Location = new Point(481, 3);
            spaceMinimize1.Name = "spaceMinimize1";
            spaceMinimize1.NoRounding = false;
            spaceMinimize1.Size = new Size(23, 21);
            spaceMinimize1.TabIndex = 8;
            spaceMinimize1.Text = "_";
            spaceMinimize1.Transparent = false;
            spaceMinimize1.WindowState = FormWindowState.Normal;
            // 
            // spaceClose1
            // 
            spaceClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spaceClose1.Customization = "DQ/S/xhh8/8yMjL/Kioq/x5/9/8ND9L//v7+/yMjI/8qKir/";
            spaceClose1.DefaultAnchor = true;
            spaceClose1.DefaultLocation = true;
            spaceClose1.Font = new Font("Verdana", 8F);
            spaceClose1.Image = null;
            spaceClose1.Location = new Point(529, 3);
            spaceClose1.Name = "spaceClose1";
            spaceClose1.NoRounding = false;
            spaceClose1.Size = new Size(23, 21);
            spaceClose1.TabIndex = 7;
            spaceClose1.Text = "x";
            spaceClose1.Transparent = false;
            // 
            // CopyPasswd
            // 
            CopyPasswd.BackColor = Color.Transparent;
            CopyPasswd.DialogResult = DialogResult.None;
            CopyPasswd.Font = new Font("Segoe UI", 10F);
            CopyPasswd.ForeColor = Color.SeaGreen;
            CopyPasswd.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            CopyPasswd.HoverForeColor = Color.White;
            CopyPasswd.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            CopyPasswd.Location = new Point(297, 291);
            CopyPasswd.MinimumSize = new Size(144, 47);
            CopyPasswd.Name = "CopyPasswd";
            CopyPasswd.NormalBackColor = Color.SeaGreen;
            CopyPasswd.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            CopyPasswd.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            CopyPasswd.PressedForeColor = Color.White;
            CopyPasswd.Radius = 20;
            CopyPasswd.RightToLeft = RightToLeft.No;
            CopyPasswd.Size = new Size(144, 47);
            CopyPasswd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            CopyPasswd.TabIndex = 6;
            CopyPasswd.Text = "Copy Password";
            CopyPasswd.Click += CopyPasswd_Click;
            // 
            // ShowPassword
            // 
            ShowPassword.BackColor = Color.Transparent;
            ShowPassword.DialogResult = DialogResult.None;
            ShowPassword.Font = new Font("Segoe UI", 10F);
            ShowPassword.ForeColor = Color.SeaGreen;
            ShowPassword.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            ShowPassword.HoverForeColor = Color.White;
            ShowPassword.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            ShowPassword.Location = new Point(297, 369);
            ShowPassword.MinimumSize = new Size(144, 47);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.NormalBackColor = Color.SeaGreen;
            ShowPassword.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            ShowPassword.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            ShowPassword.PressedForeColor = Color.White;
            ShowPassword.Radius = 20;
            ShowPassword.RightToLeft = RightToLeft.No;
            ShowPassword.Size = new Size(144, 47);
            ShowPassword.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            ShowPassword.TabIndex = 4;
            ShowPassword.Text = "Show Password";
            ShowPassword.Click += ShowPassword_Click;
            // 
            // pictureBoxQr
            // 
            pictureBoxQr.Location = new Point(297, 63);
            pictureBoxQr.Name = "pictureBoxQr";
            pictureBoxQr.Size = new Size(225, 196);
            pictureBoxQr.TabIndex = 2;
            pictureBoxQr.TabStop = false;
            // 
            // SSIDlist
            // 
            SSIDlist.BackColor = Color.FromArgb(40, 48, 51);
            SSIDlist.BorderStyle = BorderStyle.FixedSingle;
            SSIDlist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SSIDlist.ForeColor = Color.SeaGreen;
            SSIDlist.FormattingEnabled = true;
            SSIDlist.ItemHeight = 21;
            SSIDlist.Location = new Point(12, 63);
            SSIDlist.Name = "SSIDlist";
            SSIDlist.Size = new Size(254, 401);
            SSIDlist.TabIndex = 0;
            // 
            // nightLinkLabel1
            // 
            nightLinkLabel1.ActiveLinkColor = Color.SeaGreen;
            nightLinkLabel1.AutoSize = true;
            nightLinkLabel1.BackColor = Color.Transparent;
            nightLinkLabel1.Font = new Font("Segoe UI", 9F);
            nightLinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            nightLinkLabel1.LinkColor = Color.SeaGreen;
            nightLinkLabel1.Location = new Point(12, 473);
            nightLinkLabel1.Name = "nightLinkLabel1";
            nightLinkLabel1.Size = new Size(124, 15);
            nightLinkLabel1.TabIndex = 13;
            nightLinkLabel1.TabStop = true;
            nightLinkLabel1.Text = "More useful apps here";
            nightLinkLabel1.VisitedLinkColor = Color.FromArgb(254, 89, 84);
            nightLinkLabel1.LinkClicked += nightLinkLabel1_LinkClicked;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 495);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1152);
            Name = "AppForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AppForm";
            TransparencyKey = Color.Fuchsia;
            nightForm1.ResumeLayout(false);
            nightForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQr).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ListBox SSIDlist;
        private PictureBox pictureBoxQr;
        private ReaLTaiizor.Controls.LostButton lostButton1;
        private ReaLTaiizor.Controls.SpaceButton spaceButton1;
        private ReaLTaiizor.Controls.NightButton ShowPassword;
        private ReaLTaiizor.Controls.NightButton CopyPasswd;
        private ReaLTaiizor.Controls.SpaceClose spaceClose1;
        private ReaLTaiizor.Controls.SpaceMinimize spaceMinimize1;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.ForeverTextBox TextBoxPassword;
        private ReaLTaiizor.Controls.NightLinkLabel nightLinkLabel1;
    }
}