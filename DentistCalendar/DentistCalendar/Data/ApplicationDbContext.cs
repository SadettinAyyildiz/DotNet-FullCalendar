using DentistCalendar.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentistCalendar.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string> //
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Class taki Appointment ile veritabanındaki Appointments ları eşleştir. veritabanında çoğul kodda tekil kullanılır
        public DbSet<Appointment> Appointments { get; set; }
    }
}
