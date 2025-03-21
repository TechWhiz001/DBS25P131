using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

namespace DBS25P131.BusinessLayer
{
    public class ConsumableBLL
    {
        private ConsumableDAL consumableDAL = new ConsumableDAL();

        
        public bool AddConsumable(Consumables consumable)
        {
            if (string.IsNullOrWhiteSpace(consumable.ItemName) || consumable.ItemName.Length > 255)
                return false; 

            return consumableDAL.InsertConsumable(consumable);
        }

        
        public List<Consumables> GetAllConsumables()
        {
            return consumableDAL.GetAllConsumables();
        }


        public bool UpdateConsumable(Consumables consumable)
        {
            if (string.IsNullOrWhiteSpace(consumable.ItemName) || consumable.ItemName.Length > 255)
                return false; 

            return consumableDAL.UpdateConsumable(consumable);
        }

        
        public bool DeleteConsumable(int id)
        {
            return consumableDAL.DeleteConsumable(id);
        }
    }
}