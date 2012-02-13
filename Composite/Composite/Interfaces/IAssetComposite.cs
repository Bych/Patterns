using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite.Interfaces
{
    interface IAssetComposite : IAsset
    {
        void Add(params IAsset[] assets);
        Boolean Remove(IAsset asset);
    }
}
