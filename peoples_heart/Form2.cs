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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void RequestPin_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmPin_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            try
            {
                if (!string.IsNullOrEmpty(RequestPinInput.Text) && RequestPinInput.Text.Equals(ConfirmPinInput.Text))
                {
                    patient.Name = PatientNameInput.Text;
                    patient.Age = PatientAgeInput.Text;
                    patient.Pin = RequestPinInput.Text;
                    new PatientContext().AddNewPatient(patient);
                    MessageBox.Show(@"Success!");
                }
                else
                {
                    MessageBox.Show(@"Invalid Pin");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           



        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
