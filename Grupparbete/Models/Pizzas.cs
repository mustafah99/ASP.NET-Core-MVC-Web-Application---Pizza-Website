using System;
using System.ComponentModel.DataAnnotations;

namespace Grupparbete.Models
{
    public class Pizzas
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public string PizzaSizes { get; set; }
        public decimal Price { get; set; }
    }
}