using System.Collections.Generic;

namespace sample_app.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Option> Options { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public List<ProductTag> ProductTags { get; set; }
    }
}
