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

namespace peoples_heart
{
    public partial class ExistingMedicine : Form
    {
        public ExistingMedicine()
        {
            InitializeComponent();
            metroGrid1.DataSource=new MedicineContext().GetMedicineS();
        }
    }
}
