using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFactoryConsole
{
    public interface IBurger
    {
        String getImage();
        String getName();
        String getCondiments();
        String getSauce();
        String getPrice();
        String getPatty();
    }
}
