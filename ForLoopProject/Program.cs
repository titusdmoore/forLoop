using System;

namespace ForLoopProject {
    class Program {
        static void Main(string[] args) {

            int[] numbers = { 89, 188, 295, 943, 975, 277, 119, 736, 952, 321, 521, 444, 758, 397, 915, 878, 674,
                701, 379, 331, 804, 461, 459, 908, 373 };

            string[] names = { "Brailee", "Briana", "Jesse", "Titus",
                "Glenn", "Alex", "Maggie", "Marianne"};

            string allNames = null;
            foreach (string name in names) {
                string upperNames = name.ToUpper();
                allNames += upperNames;
                // Above line is the same as allNames = allNames + upperNames;
            }
            Console.WriteLine(allNames);

            //int total = 0;

            //foreach (int anInt in numbers) {
            //    total += anInt;
            //}

            ////for (int idx = 0; idx < ints.Length; idx++) {
            ////    total += ints[idx] * 3 / 4;
            ////}

            //decimal avg = total / (decimal) numbers.Length;
            //Console.WriteLine($"Total: {total} {Environment.NewLine}Average: {avg}");
        }
    }
}
