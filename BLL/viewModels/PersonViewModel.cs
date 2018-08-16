using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonskiImenik.Model;

namespace BLL.viewModels
{
    public class PersonViewModel
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime RegistrationDate { get; set; }
        
    }
}
