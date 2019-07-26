using System;

namespace ForLoopProject {
    class Program {
        static void Main(string[] args) {



            Customer[] customers = {
                new Customer { Name = "PG", State = "OH"},
                new Customer { Name = "SDCust", State = "SD"},
                new Customer { Name = "MTcust", State = "MT"}
            };

            bool FoundSDCust = false;
            bool FoundMTCust = false;

            foreach (Customer cust in customers) {
                if (cust.State == "MT") {
                    FoundMTCust = true;
                }
                if (cust.State == "SD") {
                    FoundSDCust = true;
                }

                if (FoundMTCust && FoundSDCust) {
                    break;
                }
            }

            Console.WriteLine($"Found MT: {FoundMTCust}");
            Console.WriteLine($"Found SD: {FoundSDCust}");
            int i = 0;





            //int[] numbers = { 89, 188, 295, 943, 975, 277, 119, 736, 952, 321, 521, 444, 758, 397, 915, 878, 674,
            //    701, 379, 331, 804, 461, 459, 908, 373 };

            //string[] names = { "Brailee", "Briana", "Jesse", "Titus",
            //    "Glenn", "Alex", "Maggie", "Marianne"};

            //string allNames = null;
            //foreach (string name in names) {
            //    string upperNames = name.ToUpper();
            //    allNames += upperNames;
            //    // Above line is the same as allNames = allNames + upperNames;
            //}
            //Console.WriteLine(allNames);

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
    class Customer {
        public string Name { get; set; }
        public string State { get; set; }
    }
}
