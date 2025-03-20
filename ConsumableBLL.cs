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

        // Add a new consumable with validation
        public bool AddConsumable(Consumables consumable)
        {
            if (string.IsNullOrWhiteSpace(consumable.ItemName) || consumable.ItemName.Length > 255)
                return false; // Item Name cannot be empty and must be <= 255 characters

            return consumableDAL.InsertConsumable(consumable);
        }

        // Get all consumables
        public List<Consumables> GetAllConsumables()
        {
            return consumableDAL.GetAllConsumables();
        }


        // Update a consumable with validation
        public bool UpdateConsumable(Consumables consumable)
        {
            if (string.IsNullOrWhiteSpace(consumable.ItemName) || consumable.ItemName.Length > 255)
                return false; // Item Name cannot be empty and must be <= 255 characters

            return consumableDAL.UpdateConsumable(consumable);
        }

        // Delete a consumable
        public bool DeleteConsumable(int id)
        {
            return consumableDAL.DeleteConsumable(id);
        }
    }
}