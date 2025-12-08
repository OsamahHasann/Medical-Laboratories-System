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
    public partial class Diseases : KryptonForm
    {
        int idPatients;
        public Diseases(int idPatients)
        {
            InitializeComponent();
            this.idPatients = idPatients;   

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Patient_data_Entry patient = new Patient_data_Entry();
            patient.Show();
            this.Hide();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
             
  var  selectedTests= checkedListTests.CheckedItems.Cast<Medical_Tests>().ToList();

            Results_Entry results = new Results_Entry(selectedTests,idPatients);
            this.Hide();
            results.Show();

        }
        private TestRepository testRepository=new TestRepository();

        private void Diseases_Load(object sender, EventArgs e)
        {
            LoadTestsToCheckedList();

        }
        private void LoadTestsToCheckedList()
        {
            try
            {
                var tests=testRepository.GetAll();
                checkedListTests.Items.Clear();
                foreach(var t in tests)
                {
 checkedListTests.Items.Add(t, false);
                }
                checkedListTests.DisplayMember = "TestName";
                checkedListTests.ValueMember = "TestId";


            }catch(Exception e)
            {
                MessageBox.Show("حصل غلط");
            }
        }

        private void checkedListTests_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
