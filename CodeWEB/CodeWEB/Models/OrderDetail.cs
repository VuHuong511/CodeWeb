using CodeWEB.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeWEB.Models

{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public string? BookIsbn { get; set; }
        public int? Quantity { get; set; }
        public Order? Order { get; set; }
        public Book? Book { get; set; }

    }
}
