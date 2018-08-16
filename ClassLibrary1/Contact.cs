using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonskiImenik.Model
{
    public class Contact
    {
        public int ContactID { get; set; }
        public TipBroja TipBroja { get; set; }
        public string Address { get; set; }
        public int PersonID { get; set; }
        public virtual Person Person { get; set; }
    }
}
