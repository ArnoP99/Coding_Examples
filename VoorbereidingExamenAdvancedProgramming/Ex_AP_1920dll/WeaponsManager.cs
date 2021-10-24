using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_AP_1920dll
{
    public class WeaponsManager
    {
        private static readonly object safetyLock = new object();
        private static readonly object consoleLock = new object();

        private static WeaponsManager instance;

        protected List<Weapon> weaponsList;

        private WeaponsManager()
        {
            weaponsList = new List<Weapon>();
        }
        
        public static WeaponsManager GetInstance()
        {
            if (instance == null)
            {
                lock (safetyLock)
                {
                    if (instance == null)
                    {
                        instance = new WeaponsManager();
                    }
                }
            }
            return instance;
        }

        public void AddWeapon(Weapon weaponToAdd)
        {
            weaponsList.Add(weaponToAdd);
        }

        public void PrintText(string stringToPrint)
        {
            lock (consoleLock)
            {
                Console.WriteLine(stringToPrint);
            }
        }

        public Weapon GetWeapon(int indexOfWeapon)
        {
            try
            {
                return weaponsList.ElementAt(indexOfWeapon);
            }
            catch(Exception ex)
            {
                String exceptionOutput = "The index that was given was incorrect, try an index between 0 and " + weaponsList.Count()
                    + "\n Exception output: " + ex.ToString();
                Console.WriteLine(exceptionOutput);
                return null;
            }
        }

        public int NumberOfWeaponsInList 
        {
            get
            {
                return weaponsList.Count();
            }
        }
    }
}
