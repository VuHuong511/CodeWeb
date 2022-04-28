using CodeWEB.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeWEB.Models

{
    public class Book
    {
        [Key]
        public string Isbn { get; set; }
        public string? Title { get; set; }
        public int? Pages { get; set; }
        public string? Author { get; set; }
        public string? Category { get; set; }
        public double? Price { get; set; }
        public string? Desc { get; set; }
        public string? ImgUrl { get; set; }
        public int? StoreId { get; set; }
        public Store? Store { get; set; }
        public virtual ICollection<OrderDetail>? OrderDetails { get; set; }

    }
}
