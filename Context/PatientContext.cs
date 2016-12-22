using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Context
{
    public class PatientContext
    {
        public Patient VerifyPatient(string name,string pin)
        {
            using (var context = new DataBaseContext())
            {
                Patient User = (from user in context.Patients
                             where user.Name == name && user.Pin == pin
                             select user).FirstOrDefault();

                return User;

            }
        }



        public bool AddNewPatient(Patient patient)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    context.Patients.Add(patient);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
              

            }
        }


        public bool UpdatePatient(Patient patient)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    Patient User = (from user in context.Patients
                                    where user.Id==patient.Id
                                    select user).FirstOrDefault();

                    User.Name = patient.Name;
                    User.Pin = patient.Pin;
                    User.Age = patient.Age;
                    User.Id = patient.Id;

                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }


            }
        }



        public bool RemovePatient(Patient patient)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    Patient item = context.Set<Patient>().FirstOrDefault(r => r.Id == patient.Id);
                    context.Patients.Remove(item);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }


            }
        }





    }
}
