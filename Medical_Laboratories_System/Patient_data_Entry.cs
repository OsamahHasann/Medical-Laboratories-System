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
    public partial class Patient_data_Entry : KryptonForm
    {
        public Patient_data_Entry()
        {
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
