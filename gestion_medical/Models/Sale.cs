using System;
using System.ComponentModel.DataAnnotations;

namespace gestion_medical.Models
{
	public class Sale
	{
		public Sale()
		{
		}

        public Sale(int id, DateTime saleDate, Medicine soldMedicine, int quantitySold, Customer associatedCustomer)
        {
            Id = id;
            SaleDate = saleDate;
            SoldMedicine = soldMedicine;
            QuantitySold = quantitySold;
            AssociatedCustomer = associatedCustomer;
        }
        [Key]
        [Required]
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public Medicine SoldMedicine { get; set; }
        public int QuantitySold { get; set; }
        public Customer AssociatedCustomer { get; set; }


        // Méthode pour calculer le montant total de la vente
        public decimal CalculateTotalAmount()
        {
            return SoldMedicine.Price * QuantitySold;
        }

        // Méthode pour obtenir la description complète de la vente
        public string GetSaleDescription()
        {
            return $"{QuantitySold} unit(s) of {SoldMedicine.Name} sold to {AssociatedCustomer.Name} on {SaleDate.ToShortDateString()}.";
        }
    }
}

