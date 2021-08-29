using System.Collections.Generic;

namespace sample_app.Models
{
    public class Option
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<OptionValue> OptionValues { get; set; }

        public Option()
        {
        }
    }
}
