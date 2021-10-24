using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_AP_1920dll
{
    public class Weapon : IWeapon
    {
        protected string weaponName;
        protected int numberOfAmmo;
        protected int maxAmmo;
        protected string weaponSound;

        public Weapon(string newWeaponName, int newMaxAmmo, string newWeaponSound)
        {
            weaponName = newWeaponName;
            numberOfAmmo = newMaxAmmo;
            maxAmmo = newMaxAmmo;
            weaponSound = newWeaponSound;
        }

        virtual public void Shoot()
        {
            if (numberOfAmmo != 0)
            {
                numberOfAmmo--;
                WeaponsManager.GetInstance().PrintText(weaponSound);
            }
            else
            {
                WeaponsManager.GetInstance().PrintText("CLICK");
                Reload();
            }
        }

        public void Reload()
        {
            WeaponsManager.GetInstance().PrintText(weaponName + " RELOADING");
            numberOfAmmo = maxAmmo;
        }

        public string WeaponName
        {
            get
            {
                return weaponName;
            }
        }
    }
}
