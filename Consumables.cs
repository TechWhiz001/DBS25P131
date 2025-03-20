using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P131.Models
{
    public class Consumables
    {
        public int ConsumableId { get; set; }
        public string ItemName { get; set; }

        public Consumables() { }

        public Consumables(int consumableId, string itemName)
        {
            ConsumableId = consumableId;
            ItemName = itemName;
        }
    }
}

