using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Context
{
    public class MedicineContext
    {

        public Medicine GetMedicine(string name)
        {
            using (var context = new DataBaseContext())
            {
                

                Medicine medicine = (from x in context.Medicines
                                     where x.Name == name
                                select x).FirstOrDefault();

                return medicine;

            }
        }




        public List<Medicine> GetMedicinesByUid(int id)
        {
            using (var context = new DataBaseContext())
            {


                return (from x in context.Medicines
                                     where x.CustomerId == id
                                     select x).ToList();

              

            }
        }


        public List<Medicine> GetMedicineS()
        {
            using (var context = new DataBaseContext())
            {


                return (from x in context.Medicines select x).ToList();

            

            }
        }


        public bool AddnewMedicine(Medicine medicine)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    context.Medicines.Add(medicine);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }


            }
        }


        public bool UpdateMedicines(Medicine medicine)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    Medicine q = (from x in context.Medicines
                                    where x.Id == medicine.Id
                                    select x).FirstOrDefault();

                    q.Name = medicine.Name;
                    q.BeforeMeal = medicine.BeforeMeal;
                    q.CustomerId = medicine.CustomerId;
                    q.EndDate = medicine.EndDate;
                    q.Id = medicine.Id;
                    q.Interval = medicine.Interval;
                    q.StartDate = medicine.StartDate;

                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }


            }
        }



        public bool RemoveMedicine(Medicine medicine)
        {
            using (var context = new DataBaseContext())
            {
                try
                {
                    Medicine item = context.Set<Medicine>().FirstOrDefault(r => r.Id == medicine.Id);
                    context.Medicines.Remove(item);
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
