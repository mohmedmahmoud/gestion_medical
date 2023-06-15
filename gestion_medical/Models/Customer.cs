using System;
using System.ComponentModel.DataAnnotations;
namespace gestion_medical.Models

{
	public class Customer
	{
		public Customer()
		{
		}

        public Customer(int id, string name, string address, string phoneNumber)
        {
          
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}

