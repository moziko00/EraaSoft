using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(80)]
        [EmailAddress]
        public string Email { get; set; }

        public string CreditCardNumber { get; set; }

        public ICollection <Sale> Sales { get; set; }

    }
}
