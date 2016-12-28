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
       


        private List<Medicine> medicines;
        private Timer Alarm;
        private Patient patient;
        private Form1 form1;
        public Form4(Patient validUser, Form1 form1)
        {
            
            this.form1 = form1;
            patient = validUser; 
            InitializeComponent();
            medicines =new MedicineContext().GetMedicinesByUid(patient.Id);
            Alarm = new Timer {Interval = 1000};
            Alarm.Tick += Alarm_Tick;
            Alarm.Start();
          

        }

     

   

        private void Alarm_Tick(object sender, EventArgs e)
        {
            DateTime now= DateTime.Now;
            string mediList = "Time For";
            bool time = false;
            foreach (var medicine in medicines)
            {
                DateTime startDate = medicine.StartDate;
                DateTime endDate = medicine.EndDate;
                if (now < startDate || now > endDate) continue;
                if (now.Second ==0 && now.Minute==5 && now.Hour%medicine.Interval == 0)
                {
                    mediList += " "+medicine.Name;
                    time = true;
                }
            }
            if (time)
            {
                notifyIcon1.ShowBalloonTip(1000,"Notification",mediList,ToolTipIcon.Info);
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
