using Composite.BaseClasses;

namespace Composite.Classes
{
    class Club : AssetComposite
    {
        internal Club(string title, double charge = 0) : base(title, charge)
        {
        }
    }
}
