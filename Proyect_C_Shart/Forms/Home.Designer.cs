
namespace Proyect_C_Shart.Forms
{
    partial class FormHome
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
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_home1 = new System.Windows.Forms.Label();
            this.lbl_home2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_home.Image = global::Proyect_C_Shart.Properties.Resources.board;
            this.pictureBox_home.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(525, 347);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_home.TabIndex = 0;
            this.pictureBox_home.TabStop = false;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Welcome.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Welcome.Location = new System.Drawing.Point(189, 9);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(138, 31);
            this.lbl_Welcome.TabIndex = 3;
            this.lbl_Welcome.Text = "WELCOME";
            // 
            // lbl_home1
            // 
            this.lbl_home1.AutoSize = true;
            this.lbl_home1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_home1.Location = new System.Drawing.Point(114, 40);
            this.lbl_home1.Name = "lbl_home1";
            this.lbl_home1.Size = new System.Drawing.Size(315, 25);
            this.lbl_home1.TabIndex = 4;
            this.lbl_home1.Text = "EMPRESA DE FINANCIAMIENTO ";
            // 
            // lbl_home2
            // 
            this.lbl_home2.AutoSize = true;
            this.lbl_home2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_home2.Font = new System.Drawing.Font("Bernard MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home2.ForeColor = System.Drawing.Color.Blue;
            this.lbl_home2.Location = new System.Drawing.Point(225, 286);
            this.lbl_home2.Name = "lbl_home2";
            this.lbl_home2.Size = new System.Drawing.Size(69, 22);
            this.lbl_home2.TabIndex = 6;
            this.lbl_home2.Text = " PRESTO";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 347);
            this.Controls.Add(this.lbl_home2);
            this.Controls.Add(this.lbl_home1);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.pictureBox_home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_home1;
        private System.Windows.Forms.Label lbl_home2;
    }
}