using Composite.BaseClasses;

namespace Composite.Classes
{
    class District : AssetComposite
    {
        internal District(string title, double charge = 0) : base(title, charge)
        {
        }
    }
}
