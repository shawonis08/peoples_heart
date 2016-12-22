using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace peoples_heart.Resources
{
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        private Patient patient;
        private Form1 form1;
        public Form4(Patient validUser, Form1 form1)
        {
            this.form1 = form1;
            this.patient = validUser;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new ExistingMedicine().Show();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            new Form5(patient).Show();
        }

        protected override void OnClosed(EventArgs e)
        {
            form1.Close();
            base.OnClosed(e);
        }
    }
}
