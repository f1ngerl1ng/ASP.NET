using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroShop.Main.Models;

namespace IntroShop.Main.Interfaces
{
    public interface ISsdCategory
    {
        IEnumerable<SsdCategory> AllSsdCategories { get; }
    }
}
