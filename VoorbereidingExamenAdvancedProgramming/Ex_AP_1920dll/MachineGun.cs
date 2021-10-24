using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_AP_1920dll
{
    public class MachineGun : Weapon
    {
        protected int burst;

        public MachineGun() : base("MachineGun", 100, "ratatata")
        {
            burst = 10;
        }

        public override void Shoot()
        {
            if(numberOfAmmo >= burst)
            {
                numberOfAmmo -= burst;
                WeaponsManager.GetInstance().PrintText(weaponSound);
            }
            else
            {
                WeaponsManager.GetInstance().PrintText("CLICKCLICKCLICK");
                Reload();
            }
        }
    }
}
