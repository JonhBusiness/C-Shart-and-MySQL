using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Proyect_C_Shart.Forms
{
    
   
    public partial class System_Form : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        //Contructor
        public System_Form()
        {
            InitializeComponent();
          //  this.Text = string.Empty;
         //   this.ControlBox = false;//ELIMINAMOS LOS CONTROLES PREDETERMINADOS
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel_Menu.Controls.Add(leftBorderBtn);
         

            // Presionar el botón "btn_home" por defecto
          ActiveButton(btn_home, RBGColors.color1);//solo activa el boton
            OpenChildForm(new Forms.FormHome());//Activa el form
        }

        private new Form ActiveForm;
        //struct
        private struct RBGColors
        {
            public static Color color1 = Color.FromArgb(24, 161, 251);
            public static Color color2 = Color.FromArgb(95, 77, 221);
            public static Color color3 = Color.FromArgb(1, 100, 100);
            public static Color color4 = Color.FromArgb(71, 90, 124);

        }
        //Methods
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButtom();
                //buttom
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border buttom
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon home
                iconPicture.IconChar = currentBtn.IconChar;
                iconPicture.IconColor = color;
                //panel
                label_Title.ForeColor = color;

                
            }
        }
        private void DisableButtom()
        {
            if (currentBtn != null)
            {
               // currentBtn.BackColor = Color.FromArgb(8, 25, 53);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
            {
                //open only form
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Desktop.Controls.Add(childForm);
            panel_Desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label_Title.Text = childForm.Text;
        }


        private void btn_home_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColors.color1);
            OpenChildForm(new FormHome());
        }

        private void Btn_search(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColors.color2);
            OpenChildForm(new FormSearch());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColors.color3);
            OpenChildForm(new FormAdd());
        }

        private void btn_custumers_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RBGColors.color4);
            OpenChildForm(new FormCustomers());
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaxi_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
