using System;
namespace sample_app.Models
{
    public class ProductTag
    {
        public DateTime PublicationDate { get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }

        public string TagId { get; set; }
        public Tag Tag { get; set; }

        public ProductTag()
        {
        }
    }
}
