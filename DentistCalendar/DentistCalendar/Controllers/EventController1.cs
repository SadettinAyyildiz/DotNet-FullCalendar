using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentistCalendar.Controllers
{
    [Route("event")]  // -> /event geldiğinde bu controller çalışır
    public class EventController1 : Controller
    {
        [Route("")] //içi boş olduğu için default çalışır
        [Route("~/add")] // önünde ne yazdığı önemli değil, add geldiğinde burası çalışır
        public string Add() 
        {
            return "Add";
        }

        [Route("update/{id?}")] //opsiyonel olarak id gelebilir
        public string Update(int id = 0)
        {
            return $"Update {id}";
        }


    }
}
