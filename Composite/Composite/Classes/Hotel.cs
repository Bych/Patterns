using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Composite.BaseClasses;

namespace Composite.Classes
{
    class Hotel : AssetComposite
    {
        internal Hotel(string title, double charge = 0) : base(title, charge)
        {
        }
    }
}
