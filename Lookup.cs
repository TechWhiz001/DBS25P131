using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class Lookup
    {
        public int LookupId { get; set; }
        public string Category { get; set; }
        public string Value { get; set; }

        public Lookup() { }

        public Lookup(int lookupId, string category, string value)
        {
            LookupId = lookupId;
            Category = category;
            Value = value;
        }
    }
}
