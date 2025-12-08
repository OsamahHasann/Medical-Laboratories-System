using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Medical_Laboratories_System
{
    public partial class Login_in : KryptonForm
    {
        public Login_in()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
           
                string username = selectUser.SelectedItem.ToString();
                string docPassword = "doc";
                string manPassword = "man";
                string devPassword = "dev";
                if (username == "الطبيب" && txtPass.Text == docPassword)
                {
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                    return;
                }
                else if (username == "المدير" && txtPass.Text == manPassword)
                {
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                    return;
                }
                else if (username == "المطور" && txtPass.Text == devPassword)
                {
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                    return;
                }





            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
