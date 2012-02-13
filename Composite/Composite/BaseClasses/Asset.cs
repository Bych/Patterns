using System;
using Composite.Interfaces;

namespace Composite.BaseClasses
{
    class Asset : IAsset
    {
        internal Asset(string title, double charge)
        {
            Title = title;
            Charge = charge;
        }

        public double Charge { get; private set; }

        public IAsset Parent { get; set; }

        public string Title { get; private set; }

        public IAsset FindChild(string childTitle)
        {
            return (Title == childTitle) ? this : null;
        }

        public void ShowProfit()
        {
            Console.WriteLine("{0}: ${1}", this.Title, this.Charge);
        }
    }
}
