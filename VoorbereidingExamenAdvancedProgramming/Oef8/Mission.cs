using System;
using System.Collections.Generic;
using System.Text;

namespace Oef8
{
    enum Status{
        ToDo, InProgress, Failed, Completed
    }
    class Mission
    {

        protected string missionName;
        protected string introText = "Mission has been started";
        protected string outroText = "Mission has been completed.";

        protected Status missionStatus;

        protected int pointsWhenCompleted;

        public Mission(string newMissionName)
        {
            missionName = newMissionName;
            missionStatus = Status.ToDo;
            PointsWhenCompleted = 0;
        }

        public virtual string Complete(out int pointsToAdd)
        {
            pointsToAdd = 50;

            missionStatus = Status.Completed;

            return outroText;
        }

        public string StartMission()
        {
            missionStatus = Status.InProgress;

            return introText;
        }

        public void Fail()
        {
            missionStatus = Status.Failed;
            Console.WriteLine("Mission has Failed!");
        }
        public string MissionName
        {
            get
            {
                return missionName;
            }
            set
            {
                missionName = value;
            }
        }

        public string IntroText
        {
            get
            {
                return introText;
            }
            set
            {
                introText = value;
            }
        }
        public string OutroText
        {
            get
            {
                return outroText;
            }
            set
            {
                outroText = value;
            }
        }

        public Status MissionStatus
        {
            get
            {
                return missionStatus;
            }
            set
            {
                missionStatus = value;
            }
        }
        
        public int PointsWhenCompleted
        {
            get
            {
                return pointsWhenCompleted;
            }
            set
            {
                pointsWhenCompleted = value;
            }
        }

    }
}
