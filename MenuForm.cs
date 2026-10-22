using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trial1KayPro
{
    public partial class MenuForm : Form
    {
        private MainForm mainForm;
        public MenuForm()
        {
            InitializeComponent();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "LiteratureForm")
                {
                    f.Close();
                    break;
                }
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            MainForm objMainWindow = new MainForm();
            this.Visible = false;
            objMainWindow.Show();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void literaturebtn_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "LiteratureForm")
                {
                    f.Close();
                    break;
                }
            }

            if (open == false)
            {
                LiteratureForm objLiteratureWindow = new LiteratureForm();
                this.Visible = true;
                objLiteratureWindow.Show();
            }
        }


        private void MenuForm_Load(object sender, EventArgs e)
        {
            mainForm = new MainForm();
            //Refresh_Check_Box.Text = "Enable Timer di Form2";
            Refresh_Check_Box.CheckedChanged += Refresh_Check_Box_CheckedChanged;
        }

        private void Refresh_Check_Box_CheckedChanged(object sender, EventArgs e)
        {
            bool data;
            mainForm.Show();
            if (Refresh_Check_Box.Checked)
            {
                data = true;
            }
            else
            {
                data = false;
            }
            if (mainForm != null)
            {
                mainForm.EnableTimer(Refresh_Check_Box.Checked);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}