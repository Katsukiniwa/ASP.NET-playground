using System.Collections.Generic;

namespace sample_app.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Option> Options { get; set; }

    }
}
