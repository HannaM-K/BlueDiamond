using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models
{
    public class Order
    {
        [BindNever]
        public int ID { get; set; }
        [BindNever]
        public List<OrderPosition> OrderPositions { get; set; }

        [Required(ErrorMessage = "Proszę uzupełnić wszystkie pola.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę uzupełnić wszystkie pola.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Proszę uzupełnić wszystkie pola.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Proszę uzupełnić wszystkie pola.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Proszę uzupełnić wszystkie pola.")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Proszę uzupełnić wszystkie pola.")]
        public string HouseNumber { get; set; }
        [Required(ErrorMessage = "Proszę uzupełnić wszystkie pola.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Proszę uzupełnić wszystkie pola.")]
        public string ZipCode { get; set; }
    }
}
