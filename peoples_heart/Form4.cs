using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Context;
using Entity;

namespace peoples_heart.Resources
{
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        
        private Timer[] Alarms;
        private Patient patient;
        private Form1 form1;
        public Form4(Patient validUser, Form1 form1)
        {

            this.form1 = form1;
            patient = validUser;



            Medicine[] medicines = new MedicineContext().GetMedicinesByUid(patient.Id).ToArray();
            int medCount = medicines.Length;
            Alarms = new Timer[medCount];
            for (int i = 0; i < medCount; i++)
            {
                Alarms[i] = new Timer { Interval = 10000 };
                var i1 = i;
                Alarms[i].Tick += (sender, e) => AlarmEvent(sender, e, medicines[i1]);
                Alarms[i].Enabled = true;
                Alarms[i].Start();
            }




            InitializeComponent();
        }

     
        private void AlarmEvent(object sender, EventArgs eventArgs, Medicine  medicine)
        {
           
            DateTime now= DateTime.Now;
            DateTime startDate = medicine.StartDate;
            DateTime endDate = medicine.EndDate;
            if (now>= startDate && now >= endDate)//inRange
            {
                if (now.Hour%medicine.Interval==0)
                {
                    MessageBox.Show(@"Time to Take "+medicine.Name);
                  
                }
            }



        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            new ExistingMedicine(patient.Id).Show();
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
