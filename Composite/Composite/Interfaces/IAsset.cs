using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Interfaces
{
    interface IAsset
    {
        double Charge { get; }
        IAsset Parent { get; set; }
        string Title { get; }
        IAsset FindChild(string childTitle);
        void ShowProfit();
    }
}
