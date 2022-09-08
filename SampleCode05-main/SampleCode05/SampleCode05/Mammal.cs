using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode05
{
    public abstract class Mammal
    {
        public abstract void Cry();
        public virtual void Run()
        {
            Console.WriteLine("四足歩行");
        }
    }

    public class Human : Mammal,IRunnable
    {
        public override void Cry()
        {
            Console.WriteLine("わー");
        }
        public override void Run()
        {
            Console.WriteLine("二足歩行");
        }
        public void Run(float time)
        {
            Console.WriteLine("人が走るよ");
        }
    }
    public class Dog : Mammal
    {
        public override void Cry()
        {
            Console.WriteLine("ワン！");
        }
     
    }
}
