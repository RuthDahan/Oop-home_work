using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_1
{
    using System;

    struct PointStruct
    {
        public int X;
        public int Y;
    }

    class PointClass
    {
        public int X;
        public int Y;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== הדגמה א: העתקת משתנים ===");

            // Struct – value type
            PointStruct ps1 = new PointStruct { X = 1, Y = 1 };
            PointStruct ps2 = ps1;   // נוצר העתק חדש בזיכרון
            ps2.X = 100;

            Console.WriteLine($"Struct: ps1.X={ps1.X}, ps2.X={ps2.X}");
            // ps1 לא השתנה → כי זה value-type

            // Class – reference type
            PointClass pc1 = new PointClass { X = 1, Y = 1 };
            PointClass pc2 = pc1;     // שניהם מצביעים לאותו אובייקט
            pc2.X = 200;

            Console.WriteLine($"Class: pc1.X={pc1.X}, pc2.X={pc2.X}");
            // pc1 כן השתנה → כי שניהם מצביעים לאותו אובייקט


            Console.WriteLine("\n=== הדגמה ב: העברה לפונקציה ===");

            PointStruct ps3 = new PointStruct { X = 5, Y = 5 };
            ModifyStruct(ps3); // לא משפיע
            Console.WriteLine($"After ModifyStruct (by value): ps3.X={ps3.X}");

            PointClass pc3 = new PointClass { X = 5, Y = 5 };
            ModifyClass(pc3); // כן משפיע
            Console.WriteLine($"After ModifyClass (by reference): pc3.X={pc3.X}");


            Console.WriteLine("\n=== הדגמה ג: שינוי struct בתוך פונקציה באמצעות ref ===");

            PointStruct ps4 = new PointStruct { X = 7, Y = 7 };
            ModifyStructByRef(ref ps4);  // משפיע!
            Console.WriteLine($"After ModifyStructByRef: ps4.X={ps4.X}");
        }

        // לא ישנה את struct כי הוא עובר by-value
        static void ModifyStruct(PointStruct p)
        {
            p.X = 999;
        }

        // כן ישנה class כי הוא הפניה לאותו אובייקט
        static void ModifyClass(PointClass p)
        {
            p.X = 999;
        }

        // דרישה ג – שינוי struct באמצעות ref
        static void ModifyStructByRef(ref PointStruct p)
        {
            p.X = 999;
        }
    }
}
