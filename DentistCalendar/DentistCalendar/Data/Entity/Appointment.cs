using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentistCalendar.Data.Entity
{
    public class Appointment
    {
        public int Id { get; set; }

        // foreign key 
        public int UserId { get; set; }

        //navigasyon property -> entity artık bunun bir user olduğunu ve bir üstteki user id nin foreign key olduğunu bilecek
        public AppUser User { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string Description { get; set; }
    }
}
