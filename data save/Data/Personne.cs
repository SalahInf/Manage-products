using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_save
{
   public class Personne
    {
        private string _name;
        public string Name { set; get; }
        

        public int dataId { get; set; }
        public string LastName { get; set; }
        public string Addresse { get; set; }


        public int NumPhone { get; set; }
    }
}
;