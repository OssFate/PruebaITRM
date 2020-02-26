using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Sale
    {
        public string SaleClientId { get; set; }
        public string SaleVehicleId { get; set; }

        public DateTime SaleDate { get; set; }
        public bool PaidFull { get; set; }
    }
}
