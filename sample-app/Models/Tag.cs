using System.Collections.Generic;

namespace sample_app.Models
{
    public class Tag
    {
        public string TagId { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public List<ProductTag> ProductTags { get; set; }

        public Tag()
        {
        }
    }
}
