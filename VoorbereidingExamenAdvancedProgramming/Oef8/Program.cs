using System;

namespace Oef8
{
    class Program
    {
        static void Main(string[] args)
        {
            Mission mission1 = new BonusMission("MissionComplete", true);
            Mission mission2 = new BonusMission("MissionFailed",false);

            int pointsToAdd = 0;

            Console.WriteLine(mission1.StartMission());
            Console.WriteLine(mission1.Complete(out pointsToAdd));
            mission1.PointsWhenCompleted += pointsToAdd;
            Console.WriteLine(mission1.PointsWhenCompleted);

            Console.WriteLine(mission2.StartMission());
            mission2.Fail();
            Console.WriteLine(mission2.PointsWhenCompleted);

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
