using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Badge_Console_Application_Challenges
{
    class MenuDetailsRepository
    {
        public readonly List<MenuDetails> _menuDetails = new List<MenuDetails>();
        public bool AddMenuDetails(MenuDetails content)
        {
            int startingCount = _menuDetails.Count;

        _menuDetails.Add(content);

            bool wasAdded = (_menuDetails.Count > startingCount) ? true : false;
            return wasAdded; 
        }
        public bool RemoveExistingItem(MenuDetails existingItem)
        {
            bool removeItem = _menuDetails.Remove(existingItem);
            return removeItem;
        }
        public List<MenuDetails> GetDetails()
        {
            return _menuDetails;
        }
}
}
