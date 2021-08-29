using System.Collections.Generic;

namespace sample_app.Models
{
    public class OptionValue
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string OptionId { get; set; }
        public Option Option { get; set; }

        public OptionValue()
        {
        }
    }
}
