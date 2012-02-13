using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class LaserWeapon
    {
        private void SetBattery()
        {
        }

        private void SetPower()
        {
        }

        private void Activate()
        {
        }

        public void UseWeapon()
        {
            SetBattery();
            SetPower();
            Activate();
        }
    }
}
