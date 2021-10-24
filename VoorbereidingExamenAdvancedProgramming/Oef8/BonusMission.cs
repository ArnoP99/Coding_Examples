using System;
using System.Collections.Generic;
using System.Text;

namespace Oef8
{
    class BonusMission : Mission
    {
        protected int bonusPoints = 0;

        protected bool getPoints = false;

        public BonusMission(string newMissionName, bool GetPoints) : base(null)
        {
            missionName = newMissionName;
            getPoints = GetPoints;            
        }
        public override string Complete(out int pointsToAdd)
        {
            BonusPoints = 100;
            if(getPoints == true)
            {
                pointsToAdd = 50;
                pointsToAdd += bonusPoints;
            }
            else
            {
                pointsToAdd = 50;
            }
           

            missionStatus = Status.Completed;

            return outroText;
        }

        public int BonusPoints
        {
            get
            {
                return bonusPoints;
            }
            set
            {
                bonusPoints = value;
            }
        }

        public bool GetPoints
        {
            get
            {
                return getPoints;
            }
            set
            {
                getPoints = value;
            }
        }
    }
}
