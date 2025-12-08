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
    public partial class print : KryptonForm
    {  
        
        private PatientRepository repo;
        private BindingSource bs= new BindingSource();

     public print() 
        { 
            
            InitializeComponent();

            repo = new PatientRepository();
            dataGridView1.AutoGenerateColumns=false;
           
          
            dataGridView1.DataSource = bs;
            ConfigureGridColumn();
           
        }
        private void ConfigureGridColumn()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PatientId"
              ,
                HeaderText = "ID",
                Width = 100
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName= "FullName"
                ,
                HeaderText="الاسم",
                Width  =120
            });
           
        }

        private void print_Load(object sender, EventArgs e)
        {
            LoadPatinents();
        }
        private async void LoadPatinents()
        {
            try{
                var list = await Task.Run(() =>  repo.GetAllPatients());
             
                
                bs.DataSource = list;


            }catch (Exception e)
            {
                MessageBox.Show("حصل غلط بجلب البيانات");

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            this.Hide();
            record.Show();
        }
    }
}
