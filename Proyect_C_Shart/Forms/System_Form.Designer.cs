
namespace Proyect_C_Shart.Forms
{
    partial class System_Form
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
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.control_Gradient1 = new Proyect_C_Shart.Colors.Control_Gradient();
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_custumers = new FontAwesome.Sharp.IconButton();
            this.lblcompany = new System.Windows.Forms.Label();
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.btn_home = new FontAwesome.Sharp.IconButton();
            this.panel_Label = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.iconPicture = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_home = new System.Windows.Forms.Label();
            this.btnmini = new System.Windows.Forms.Button();
            this.btnmaxi = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.panel_Shadow = new System.Windows.Forms.Panel();
            this.panel_Desktop = new System.Windows.Forms.Panel();
            this.panelAvatar.SuspendLayout();
            this.control_Gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            this.panel_Menu.SuspendLayout();
            this.panel_Label.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAvatar
            // 
            this.panelAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.panelAvatar.Controls.Add(this.control_Gradient1);
            this.panelAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAvatar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAvatar.Location = new System.Drawing.Point(0, 0);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(196, 118);
            this.panelAvatar.TabIndex = 1;
            // 
            // control_Gradient1
            // 
            this.control_Gradient1.Angle = 201F;
            this.control_Gradient1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.control_Gradient1.BorderRadius = 20;
            this.control_Gradient1.Color0 = System.Drawing.Color.DarkSlateBlue;
            this.control_Gradient1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.control_Gradient1.Controls.Add(this.picture_user);
            this.control_Gradient1.Controls.Add(this.label1);
            this.control_Gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Gradient1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Bold);
            this.control_Gradient1.Location = new System.Drawing.Point(0, 0);
            this.control_Gradient1.Name = "control_Gradient1";
            this.control_Gradient1.Size = new System.Drawing.Size(196, 118);
            this.control_Gradient1.TabIndex = 4;
            // 
            // picture_user
            // 
            this.picture_user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_user.Image = global::Proyect_C_Shart.Properties.Resources.loginuser;
            this.picture_user.Location = new System.Drawing.Point(49, 27);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(100, 69);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_user.TabIndex = 0;
            this.picture_user.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(46, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMINISTRADOR";
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.panel_Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Menu.Controls.Add(this.btn_custumers);
            this.panel_Menu.Controls.Add(this.lblcompany);
            this.panel_Menu.Controls.Add(this.btn_add);
            this.panel_Menu.Controls.Add(this.btn_search);
            this.panel_Menu.Controls.Add(this.btn_home);
            this.panel_Menu.Controls.Add(this.panelAvatar);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(198, 415);
            this.panel_Menu.TabIndex = 2;
            // 
            // btn_custumers
            // 
            this.btn_custumers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_custumers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_custumers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_custumers.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_custumers.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_custumers.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btn_custumers.IconColor = System.Drawing.Color.White;
            this.btn_custumers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_custumers.IconSize = 40;
            this.btn_custumers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_custumers.Location = new System.Drawing.Point(0, 301);
            this.btn_custumers.Name = "btn_custumers";
            this.btn_custumers.Size = new System.Drawing.Size(196, 61);
            this.btn_custumers.TabIndex = 8;
            this.btn_custumers.Text = " CUSTOMERS";
            this.btn_custumers.UseVisualStyleBackColor = true;
            this.btn_custumers.Click += new System.EventHandler(this.btn_custumers_Click);
            // 
            // lblcompany
            // 
            this.lblcompany.AutoSize = true;
            this.lblcompany.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompany.ForeColor = System.Drawing.Color.Blue;
            this.lblcompany.Location = new System.Drawing.Point(56, 379);
            this.lblcompany.Name = "lblcompany";
            this.lblcompany.Size = new System.Drawing.Size(74, 17);
            this.lblcompany.TabIndex = 9;
            this.lblcompany.Text = " PRESTO";
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_add.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btn_add.IconColor = System.Drawing.Color.White;
            this.btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add.IconSize = 40;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(0, 240);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(196, 61);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "ADD NEW";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_search
            // 
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_search.IconColor = System.Drawing.Color.White;
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.IconSize = 40;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(0, 179);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(196, 61);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Btn_search);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_home.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_home.IconColor = System.Drawing.Color.White;
            this.btn_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_home.IconSize = 40;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 118);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(196, 61);
            this.btn_home.TabIndex = 5;
            this.btn_home.Text = "HOME";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_Label
            // 
            this.panel_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.panel_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Label.Controls.Add(this.label_Title);
            this.panel_Label.Controls.Add(this.iconPicture);
            this.panel_Label.Controls.Add(this.lbl_home);
            this.panel_Label.Controls.Add(this.btnmini);
            this.panel_Label.Controls.Add(this.btnmaxi);
            this.panel_Label.Controls.Add(this.btnX);
            this.panel_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Label.Location = new System.Drawing.Point(198, 0);
            this.panel_Label.Name = "panel_Label";
            this.panel_Label.Size = new System.Drawing.Size(525, 58);
            this.panel_Label.TabIndex = 3;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.Blue;
            this.label_Title.Location = new System.Drawing.Point(57, 22);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(53, 17);
            this.label_Title.TabIndex = 13;
            this.label_Title.Text = "HOME";
            // 
            // iconPicture
            // 
            this.iconPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(62)))));
            this.iconPicture.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.iconPicture.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPicture.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.iconPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPicture.Location = new System.Drawing.Point(19, 11);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(32, 32);
            this.iconPicture.TabIndex = 0;
            this.iconPicture.TabStop = false;
            // 
            // lbl_home
            // 
            this.lbl_home.AutoSize = true;
            this.lbl_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_home.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.ForeColor = System.Drawing.Color.Blue;
            this.lbl_home.Location = new System.Drawing.Point(167, 18);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(190, 24);
            this.lbl_home.TabIndex = 5;
            this.lbl_home.Text = "COMPANY PRESTO";
            this.lbl_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnmini
            // 
            this.btnmini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmini.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnmini.Location = new System.Drawing.Point(444, 0);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(29, 23);
            this.btnmini.TabIndex = 12;
            this.btnmini.Text = "-";
            this.btnmini.UseVisualStyleBackColor = true;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            // 
            // btnmaxi
            // 
            this.btnmaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaxi.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmaxi.ForeColor = System.Drawing.Color.Blue;
            this.btnmaxi.Location = new System.Drawing.Point(468, 0);
            this.btnmaxi.Name = "btnmaxi";
            this.btnmaxi.Size = new System.Drawing.Size(29, 23);
            this.btnmaxi.TabIndex = 11;
            this.btnmaxi.Text = "O";
            this.btnmaxi.UseVisualStyleBackColor = true;
            this.btnmaxi.Click += new System.EventHandler(this.btnmaxi_Click);
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Red;
            this.btnX.Location = new System.Drawing.Point(494, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(29, 23);
            this.btnX.TabIndex = 10;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // panel_Shadow
            // 
            this.panel_Shadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.panel_Shadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Shadow.Location = new System.Drawing.Point(198, 58);
            this.panel_Shadow.Name = "panel_Shadow";
            this.panel_Shadow.Size = new System.Drawing.Size(525, 10);
            this.panel_Shadow.TabIndex = 4;
            // 
            // panel_Desktop
            // 
            this.panel_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Desktop.Location = new System.Drawing.Point(198, 68);
            this.panel_Desktop.Name = "panel_Desktop";
            this.panel_Desktop.Size = new System.Drawing.Size(525, 347);
            this.panel_Desktop.TabIndex = 5;
            // 
            // System_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 415);
            this.Controls.Add(this.panel_Desktop);
            this.Controls.Add(this.panel_Shadow);
            this.Controls.Add(this.panel_Label);
            this.Controls.Add(this.panel_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "System_Form";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platform";
            this.panelAvatar.ResumeLayout(false);
            this.control_Gradient1.ResumeLayout(false);
            this.control_Gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.panel_Label.ResumeLayout(false);
            this.panel_Label.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picture_user;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Label;
        private System.Windows.Forms.Button btnmini;
        private System.Windows.Forms.Button btnmaxi;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lbl_home;
        private FontAwesome.Sharp.IconButton btn_home;
        private FontAwesome.Sharp.IconButton btn_custumers;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_search;
        private System.Windows.Forms.Label lblcompany;
        private Colors.Control_Gradient control_Gradient1;
        private System.Windows.Forms.Panel panel_Shadow;
        private FontAwesome.Sharp.IconPictureBox iconPicture;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel_Desktop;
    }
}