using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Patient
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Pin { get; set; }
        public string Age { get; set; }
    }
}
