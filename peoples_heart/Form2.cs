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
using Tulpep.NotificationWindow;

namespace peoples_heart.Resources
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        int i;
        
        public Form2()
        {
            InitializeComponent();
            for (i = 1; i <= 100; i++)
            {
                PatientAgeInput.Items.Add(Convert.ToString(i));
            }
            
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
                if (!string.IsNullOrEmpty(PatientNameInput.Text))
                {
                    if (!string.IsNullOrEmpty(PatientAgeInput.Text))
                    {
                        if (!string.IsNullOrEmpty(RequestPinInput.Text) && RequestPinInput.Text.Equals(ConfirmPinInput.Text))
                        {
                            if (RequestPinInput.Text.Length == 5)
                            {
                                patient.Name = PatientNameInput.Text;
                                patient.Age = PatientAgeInput.Text;
                                patient.Pin = RequestPinInput.Text;
                                new PatientContext().AddNewPatient(patient);
                                //MessageBox.Show(@"Success!");
                                PopupNotifier confirmRegister = new PopupNotifier();
                                confirmRegister.ContentText = "You are Successfully Registered.Remember your PIN Number.";
                                confirmRegister.Popup();
                            }
                            else
                            {
                                MessageBox.Show("Password length should be 5.");
                                RequestPinInput.Focus();
                            }

                        }
                        else
                        {
                            PopupNotifier pinValidation = new PopupNotifier();
                            pinValidation.ContentText = "Invalid Pin";
                            pinValidation.Popup();
                            //MessageBox.Show(@"Invalid Pin");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Please enter your age.");
                        PatientAgeInput.Focus();
                    }

                }
                else
                {
                    MessageBox.Show(@"Please enter your name.");
                    PatientNameInput.Focus();
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

        private void PatientAgeInput_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PatientAgeInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPinInput_Click(object sender, EventArgs e)
        {

        }

        private void RequestPinInput_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (RequestPinInput.PasswordChar == '*')
            {
                RequestPinInput.PasswordChar = '\0';
                showButton.Text = "Hide";
            }
            else if(RequestPinInput.PasswordChar == '\0')
            {
                RequestPinInput.PasswordChar = '*';
                showButton.Text = "Show";
            }
        }

        private void PatientAge_Click(object sender, EventArgs e)
        {

        }

        private void PatientNameInput_Click(object sender, EventArgs e)
        {

        }
    }
}
