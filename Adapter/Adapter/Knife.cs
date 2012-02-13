using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public abstract class Knife
    {
        public abstract void Cut();
    }

    internal class KitchenKnife : Knife
    {
        public override void Cut()
        {
            GoForth();
            GoBack();
        }

        public void GoForth()
        {
        }

        public void GoBack()
        {
        }
    }

    internal class LaserKnife : Knife
    {
        readonly LaserWeapon _lw = new LaserWeapon();

        public override void Cut()
        {
            _lw.UseWeapon();
        }
    }
}
