using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PizzaShop.Models
{
    public class Order
    {
        //Order ID of the order
        public int OrderID { get; set; }
        //The status of the order, whether it is delivered.
        public bool Delivered { get; set; }
        [BindNever]
        public bool Shipped { get; set; }   
        public bool Completed { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Please enter the address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }
    }
}
