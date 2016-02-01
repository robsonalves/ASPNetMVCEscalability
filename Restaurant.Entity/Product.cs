using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Entity
{
    [Serializable]
    public class Product
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        [NotMapped]
        public int Quantidade { get; set; }

    }
}