
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Net.Mime.MediaTypeNames;

namespace Medical_Laboratories_System
{
    public partial class Results_Entry : KryptonForm
    {
        int IdPatnients;
        List<Medical_Tests> SelectedTests= new List<Medical_Tests>() ;
        public Results_Entry(List<Medical_Tests> selectedTests,int IdPatnients)
        {
            InitializeComponent();
            this.SelectedTests = selectedTests; 
            this.IdPatnients = IdPatnients; 
        }
 TextBox txtResult;
        DateTimePicker dt;
        private void Results_Entry_Load(object sender, EventArgs e)
        {
            PatientRepository patientRepository = new PatientRepository();
            patientRepository.GetAllPatients();
            int row=0;
            foreach (var test in SelectedTests)
            {
                Label lbl = new Label();
                lbl.Text = test.TestName;
                lbl.AutoSize = true;

                txtResult = new TextBox();
                txtResult.Name = "txtResult_" + test.TestId;
                txtResult.Width = 200;


                dt = new DateTimePicker();
                dt.Name = "dtDate_" + test.TestId;
                dt.Format = DateTimePickerFormat.Short;

                tableLayoutPanel1.Controls.Add(lbl,0,row);
                tableLayoutPanel1.Controls.Add(txtResult, 1, row);
                tableLayoutPanel1.Controls.Add(dt, 2, row);
                row++;
            }

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            BookingRepository repo = new BookingRepository();

            foreach (var test in SelectedTests)
            {
                DateTime resultDate = dt?.Value ?? DateTime.Now;


               repo.AddBooking(IdPatnients, test.TestId, txtResult.Name, resultDate);
            }

            MessageBox.Show("تم حفظ الفحوصات بنجاح ✔");
            print p = new print();
            this.Hide();
            p.Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Diseases diseases = new Diseases(IdPatnients);
            diseases.Show();
            this.Hide();
        }
    }
}
