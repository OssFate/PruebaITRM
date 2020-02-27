using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Client SaleClient { get; set; }
        public string SaleClientId { get; set; }
        public Vehicle SaleVehicle { get; set; }
        public string SaleVehicleId { get; set; }

        public DateTime SaleDate { get; set; }
        public bool PaidFull { get; set; }
    }
}
