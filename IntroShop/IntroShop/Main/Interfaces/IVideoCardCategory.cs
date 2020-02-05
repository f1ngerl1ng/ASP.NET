
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Interfaces
{
    public interface IVideoCardCategory
    {
        IEnumerable<VideoCardCategory> AllVideoCardCategories { get; }
    }
}
