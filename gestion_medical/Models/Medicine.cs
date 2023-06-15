

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace gestion_medical.Models
{
	public class Medicine
	{
		public Medicine()
		{
		}

        public Medicine(int id, string name, string description, decimal price, int quantityInStock)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        // Méthode pour vérifier si le médicament est en stock
        public bool IsInStock()
        {
            return QuantityInStock > 0;
        }

        // Méthode pour déduire une certaine quantité du stock
        public void DeductStock(int quantity)
        {
            if (quantity <= QuantityInStock)
                QuantityInStock -= quantity;
            else
                throw new Exception("Insufficient stock.");
        }
    }
}

