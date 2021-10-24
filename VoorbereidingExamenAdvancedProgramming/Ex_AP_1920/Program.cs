using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ex_AP_1920dll;

namespace Ex_AP_1920
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Verkeerd aantal console argumenten meegegeven aan programma.");
            }
            else
            {
                if (IsPrimeNumber(args[0].Length, (args[0].Length) / 2))
                {
                    WeaponsManager.GetInstance().AddWeapon(new Pistol());
                }
                else
                {
                    WeaponsManager.GetInstance().AddWeapon(new Pistol());
                    WeaponsManager.GetInstance().AddWeapon(new Pistol());
                }

                if (IsPrimeNumber(args[1].Length, (args[1].Length) / 2))
                {
                    WeaponsManager.GetInstance().AddWeapon(new MachineGun());
                    WeaponsManager.GetInstance().AddWeapon(new MachineGun());
                }
                else
                {
                    WeaponsManager.GetInstance().AddWeapon(new MachineGun());
                }

                List<Thread> threadsList = new List<Thread>();

                for (int i = 0; i < WeaponsManager.GetInstance().NumberOfWeaponsInList; i++)
                {
                    Weapon tempWeapon = WeaponsManager.GetInstance().GetWeapon(i);
                    if (tempWeapon.WeaponName == "Pistol")
                    {
                        Thread t = new Thread(() => ShootFullForce(tempWeapon, 300));
                        threadsList.Add(t);
                    }
                    else
                    {
                        Thread t = new Thread(() => ShootFullForce(tempWeapon, 500));
                        threadsList.Add(t);
                    }
                }

                foreach (var thread in threadsList)
                {
                    thread.Start();
                    thread.Join(5000);
                }

                foreach (var thread in threadsList)
                {
                    thread.Abort();
                }
            }
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }

        static void ShootFullForce(Weapon weaponToShoot, int pauseValue)
        {
            WeaponsManager.GetInstance().PrintText("\nStart shooting new weapon:");

            while (true)
            {
                weaponToShoot.Shoot();
                Thread.Sleep(pauseValue);
            }
        }

        static bool IsPrimeNumber(int numberToCheck, int halfOfNumberToCheck)
        {
            if (halfOfNumberToCheck == 1)
            {
                return true;
            }
            else
            {
                if (numberToCheck % halfOfNumberToCheck == 0)
                    return false;
                else
                    return IsPrimeNumber(numberToCheck, halfOfNumberToCheck - 1);
            }
        }
    }
}


