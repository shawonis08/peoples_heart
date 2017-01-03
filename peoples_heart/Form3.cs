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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        textToSpeech ts = new textToSpeech();
        private Form1 form1;
        public Form3(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void PatientPin_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Patient validUser = new PatientContext().VerifyPatient(PatientNameInput.Text, PatientPinInput.Text);
            PopupNotifier loginSuccess = new PopupNotifier();
            loginSuccess.ContentText = "Welcome" + " " + PatientNameInput.Text;
            loginSuccess.Popup();

            if (validUser == null)
            {
                PopupNotifier userInvalid = new PopupNotifier();
                userInvalid.ContentText = "Invalid User";
                userInvalid.Popup();
                //MessageBox.Show("Invalid User");
            }
            else
            {
                this.Close();
                new Form4(validUser, form1).Show();

                form1.Hide();

            }
        }

        private void CancelButton_hv(object sender, EventArgs e)
        {
            ts.speak((sender as Button).Text);
        }

        private void ConfirmButton_hv(object sender, EventArgs e)
        {
            ts.speak((sender as Button).Text);
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
