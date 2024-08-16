using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proj1.Entities.OneToMany
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid CustomerId { get; set; } // Foreign Key
        public decimal Amount { get; set; }

        // Navigation property
        public Customer Customer { get; set; }
    }
}
