using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Context
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext():base("name=MedicineDatabase")
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        


    }
}
