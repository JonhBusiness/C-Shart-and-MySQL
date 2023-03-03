
namespace Proyect_C_Shart
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnX = new System.Windows.Forms.Button();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.control_Gradient1 = new Proyect_C_Shart.Colors.Control_Gradient();
            this.panel_Gradient1 = new Proyect_C_Shart.Colors.Panel_Gradient();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.label_Question = new System.Windows.Forms.Label();
            this.link_register = new System.Windows.Forms.LinkLabel();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.picture_user = new System.Windows.Forms.PictureBox();
            this.picture_Pass = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.control_Gradient1.SuspendLayout();
            this.panel_Gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Pass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picture_user);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Location = new System.Drawing.Point(216, 250);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 41);
            this.panel2.TabIndex = 21;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(58, 15);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(168, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picture_Pass);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(216, 303);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 39);
            this.panel1.TabIndex = 20;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(58, 13);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Red;
            this.btnX.Location = new System.Drawing.Point(572, 13);
            this.btnX.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(39, 30);
            this.btnX.TabIndex = 19;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.ForeColor = System.Drawing.Color.Blue;
            this.label_Login.Location = new System.Drawing.Point(278, 196);
            this.label_Login.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(93, 38);
            this.label_Login.TabIndex = 17;
            this.label_Login.Text = "LOGIN";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(79, 303);
            this.label_password.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(125, 19);
            this.label_password.TabIndex = 14;
            this.label_password.Text = "CONTRASEÑA:";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(118, 255);
            this.label_user.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(86, 19);
            this.label_user.TabIndex = 12;
            this.label_user.Text = "USUARIO:";
            // 
            // control_Gradient1
            // 
            this.control_Gradient1.Angle = 71F;
            this.control_Gradient1.BorderRadius = 20;
            this.control_Gradient1.Color0 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.control_Gradient1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.control_Gradient1.Controls.Add(this.pictureBoxLogin);
            this.control_Gradient1.Location = new System.Drawing.Point(194, 30);
            this.control_Gradient1.Name = "control_Gradient1";
            this.control_Gradient1.Size = new System.Drawing.Size(238, 163);
            this.control_Gradient1.TabIndex = 23;
            // 
            // panel_Gradient1
            // 
            this.panel_Gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.panel_Gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.panel_Gradient1.Controls.Add(this.btn_Enter);
            this.panel_Gradient1.Controls.Add(this.label_Question);
            this.panel_Gradient1.Controls.Add(this.link_register);
            this.panel_Gradient1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Gradient1.Location = new System.Drawing.Point(0, 361);
            this.panel_Gradient1.Name = "panel_Gradient1";
            this.panel_Gradient1.Size = new System.Drawing.Size(626, 190);
            this.panel_Gradient1.TabIndex = 22;
            // 
            // btn_Enter
            // 
            this.btn_Enter.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Enter.FlatAppearance.BorderSize = 2;
            this.btn_Enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Enter.Location = new System.Drawing.Point(252, 21);
            this.btn_Enter.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(109, 37);
            this.btn_Enter.TabIndex = 15;
            this.btn_Enter.Text = "ENTRAR";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // label_Question
            // 
            this.label_Question.AutoSize = true;
            this.label_Question.Location = new System.Drawing.Point(240, 81);
            this.label_Question.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(138, 17);
            this.label_Question.TabIndex = 16;
            this.label_Question.Text = "NO TIENE CUENTA?";
            // 
            // link_register
            // 
            this.link_register.AutoSize = true;
            this.link_register.Location = new System.Drawing.Point(259, 126);
            this.link_register.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.link_register.Name = "link_register";
            this.link_register.Size = new System.Drawing.Size(92, 17);
            this.link_register.TabIndex = 18;
            this.link_register.TabStop = true;
            this.link_register.Text = "REGISTRASE";
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.pictureBoxLogin.Image = global::Proyect_C_Shart.Properties.Resources.login;
            this.pictureBoxLogin.Location = new System.Drawing.Point(38, 26);
            this.pictureBoxLogin.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(164, 116);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 13;
            this.pictureBoxLogin.TabStop = false;
            // 
            // picture_user
            // 
            this.picture_user.BackColor = System.Drawing.Color.White;
            this.picture_user.Image = global::Proyect_C_Shart.Properties.Resources.loginuser;
            this.picture_user.Location = new System.Drawing.Point(6, 4);
            this.picture_user.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(48, 33);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_user.TabIndex = 2;
            this.picture_user.TabStop = false;
            // 
            // picture_Pass
            // 
            this.picture_Pass.BackColor = System.Drawing.Color.White;
            this.picture_Pass.Image = global::Proyect_C_Shart.Properties.Resources.loginkey;
            this.picture_Pass.Location = new System.Drawing.Point(6, 4);
            this.picture_Pass.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.picture_Pass.Name = "picture_Pass";
            this.picture_Pass.Size = new System.Drawing.Size(48, 33);
            this.picture_Pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Pass.TabIndex = 2;
            this.picture_Pass.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(626, 551);
            this.Controls.Add(this.control_Gradient1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.panel_Gradient1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.control_Gradient1.ResumeLayout(false);
            this.panel_Gradient1.ResumeLayout(false);
            this.panel_Gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picture_user;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_Pass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.LinkLabel link_register;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label label_user;
        private Colors.Panel_Gradient panel_Gradient1;
        private Colors.Control_Gradient control_Gradient1;
    }
}

