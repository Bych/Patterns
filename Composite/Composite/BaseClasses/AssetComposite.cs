using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Composite.Interfaces;

namespace Composite.BaseClasses
{
    class AssetComposite : Asset, IAssetComposite
    {
        private double _charge;
        private readonly List<IAsset> _assets = new List<IAsset>(); 

        internal AssetComposite(string title, double charge = 0) :
            base(title, charge)
        {
            _charge = charge;
        }

        public void Add(params IAsset[] assets)
        {
            foreach (var asset in assets)
            {
                _assets.Add(asset); // add to child's collection
                asset.Parent = this; // set current AssetComposite as parent for Asset
            }
        }

        public bool Remove(IAsset asset)
        {
            if (_assets.Contains(asset))
            {
                _assets.Remove(asset);
                return true;
            }

            return false;
        }

        public new IAsset FindChild(string childTitle)
        {
            IAsset child = (Title == childTitle) ? this : null;

            if (child == null)
            {
                foreach (var asset in _assets)
                {
                    child = asset.FindChild(childTitle);
                    if (child != null)
                        return child;
                }
            }

            return child;
        }

        public new double Charge
        {
            get
            {
                if (_charge == 0)
                {
                    foreach (var asset in _assets)
                    {
                        _charge += asset.Charge;
                    }
                }

                return _charge;
            }

            private set { _charge = value; }
        }

        public new void ShowProfit()
        {
            Console.WriteLine("{0}: ${1}", this.Title, this.Charge);
            foreach (var asset in _assets)
            {
                var currentAsset = asset is IAssetComposite ? (IAssetComposite)asset : asset;
                asset.ShowProfit();
            }
        }
    }
}
