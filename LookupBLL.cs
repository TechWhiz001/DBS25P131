using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P131.DataAccessLayer;
using DBS25P131.Models;

namespace DBS25P131.BusinessLayer
{
    public class LookupBLL
    {
        private LookupDAL lookupDAL;

        public LookupBLL()
        {
            lookupDAL = new LookupDAL();
        }

        public List<Lookup> GetAllLookups()
        {
            return lookupDAL.GetAllLookups();
        }

        public bool AddLookup(Lookup lookup)
        {
            if (lookup == null || string.IsNullOrWhiteSpace(lookup.Category) || string.IsNullOrWhiteSpace(lookup.Value))
            {
                throw new ArgumentException("Invalid lookup data.");
            }
            return lookupDAL.InsertLookup(lookup);
        }

        public bool DeleteLookup(int lookupId)
        {
            if (lookupId <= 0)
            {
                throw new ArgumentException("Invalid lookup ID.");
            }
            return lookupDAL.DeleteLookup(lookupId);
        }
        public int getItemIdByName(string itemName)
        {
            return lookupDAL.GetItemIdByName(itemName);
        }

    }
}
