using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Context;
using Entity;

namespace peoples_heart.Resources
{
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        private Patient patient;
        public Form5(Patient patient)
        {
            this.patient = patient;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void EndDate_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

      

       

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            try
            {
                medicine.Name = MedicineNameInput.Text;
                medicine.Interval = Convert.ToInt32(TakingTimeInput.Text);
                medicine.StartDate = metroDateTime2.Value;
                medicine.EndDate = metroDateTime1.Value;
                medicine.CustomerId = patient.Id;
                medicine.BeforeMeal = BeforeMeal.Checked;
                new MedicineContext().AddnewMedicine(medicine);
                MessageBox.Show("Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BeforeMeal_CheckedChanged(object sender, EventArgs e)
        {
            metroCheckBox1.CheckState = BeforeMeal.Checked ? CheckState.Unchecked : CheckState.Checked;
            
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            BeforeMeal.CheckState = metroCheckBox1.Checked ? CheckState.Unchecked : CheckState.Checked;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
