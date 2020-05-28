using UrbanShoes.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UrbanShoes.ViewModels
{
    public class BasketViewModel
    {
        public List<BasketLines> BasketLines { get; set; }
        [Display(Name = "Basket Total:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal TotalCost { get; set; }
    }
}