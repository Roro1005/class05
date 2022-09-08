using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode05
{
    public class Functions
    {
        public static void HandsOn03(Car car)
        {
            car.Speed = 100f;
            car.Run(123f);
        }

        public static void HandsOn03_2(Car car)
        {
            car = new Car(100f);
            car.Run(12345f);
        }

        public static void RunTest(Mammal mammal)
        {
            mammal.Run();
        }
    }
}
