using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFactoryConsole
{
    public class BurgerFactory
    {
        public IBurger returnInstance;
        public IBurger getBurger(String BurgerType)
        {
            if (BurgerType.ToLower().Equals("chicken"))
            {
                returnInstance = new ChickenBurger();
            }
            else if (BurgerType.ToLower().Equals("cheese"))
            {
                returnInstance = new CheeseBurger();
            }
            else if (BurgerType.ToLower().Equals("fish"))
            {
                returnInstance = new FishBurger();
            }
            else
            {
                returnInstance = new PlainBurger();
            }
            return returnInstance;
        }
    }
}
