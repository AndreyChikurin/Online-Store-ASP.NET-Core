using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name= "Enter a name")]
        [StringLength(15)]
        [Required(ErrorMessage = "The name must be at least 1 characters long")]
        public string name { get; set; }

        [Display(Name = "Enter a surname")]
        [StringLength(15)]
        [Required(ErrorMessage = "The surname must be at least 1 characters long")]
        public string surname { get; set; }

        [Display(Name = "Enter an address")]
        [StringLength(30)]
        [Required(ErrorMessage = "The address must be at least 1 characters long")]
        public string address { get; set; }

        [Display(Name = "Enter a phone number")]
        [StringLength(11)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "The phone number must be at least 1 characters long")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Incorrect email")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)] // private for users
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
