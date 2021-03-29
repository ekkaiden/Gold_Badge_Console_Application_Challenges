using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gold_Badge_Console_Application_Challenges
{
    class MenuRepository: MenuDetailsRepository
    {
        private List<MenuDetails> GetMenuItems()
        {
            List<MenuDetails> fullMenu = new List<MenuDetails>();
            foreach (MenuDetails content in _menuDetails)
            {
                if (content is MenuDetails)
                {
                    fullMenu.Add(content as MenuDetails);
                }
            }
            return fullMenu;
        }
    }
}
