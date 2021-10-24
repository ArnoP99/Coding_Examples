using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVector
{
    public struct Vector3
    {
        public int x, y, z;

        public Vector3(int newX, int newY, int newZ)
        {
            x = newX;
            y = newY;
            z = newZ;
        }

        public static Vector3 operator +(Vector3 arg1, Vector3 arg2)
        {
            arg1.x += arg2.x;
            arg1.y += arg2.y;
            arg1.z += arg2.z;

            return arg1;
        }

        public static Vector3 operator -(Vector3 arg1, Vector3 arg2)
        {
            arg1.x -= arg2.x;
            arg1.y -= arg2.y;
            arg1.z -= arg2.z;

            return arg1;
        }

        public static Vector3 operator ++(Vector3 arg1)
        {
            arg1.x += 1;
            arg1.y += 1;
            arg1.z += 1;

            return arg1;
        }

        public override string ToString()
        {
            string s = "(" + x.ToString() + "," + y.ToString() + "," + z.ToString() + ")";
            return s;
        }
    }
    class Program
    {      
        static void Main(string[] args)
        {
            Vector3 v1 = new Vector3(4, 5, 6);
            Vector3 v2 = new Vector3(1, 2, 3);

            Console.WriteLine("V1 : " + v1.ToString());
            Console.WriteLine("V2 : " + v2.ToString());

            Console.WriteLine("V1 + V2: " + (v1+v2).ToString());
            Console.WriteLine("V1 - V2: " + (v1-v2).ToString());
            Console.WriteLine("V1++: " + (++v1).ToString());

            Console.WriteLine("Press any key to continue ... ");
            Console.ReadKey();
        }
    }
}

