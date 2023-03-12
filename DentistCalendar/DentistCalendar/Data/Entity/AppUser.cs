using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentistCalendar.Data.Entity
{
    public class AppUser : IdentityUser
    {
        public bool isDentist { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Color { get; set; }

        List<Appointment> Appointments { get; set; } // navigation property -> bire çok ilişki olan bağlantım
    }
}
