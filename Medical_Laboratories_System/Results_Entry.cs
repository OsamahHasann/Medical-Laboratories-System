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
    public partial class Results_Entry : KryptonForm
    {
        public Results_Entry()
        {
            InitializeComponent();
        }

        private void Results_Entry_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            print p = new print();
            this.Hide();
            p.Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Diseases diseases = new Diseases();
            diseases.Show();
            this.Hide();
        }
    }
}
