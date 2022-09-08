using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode05
{
    internal class Player:Character
    {
        public string Name;
        public int Level;
        public Player(string name, float maxHP, float attackPoint, float defencePoint)
            : base(maxHP, attackPoint, defencePoint)
        {
            this.Name=name;
            this.Level = 1;
        }
        public override void WriteProfile()
        {
            Console.WriteLine("味方です。名前は" + Name);
        }
    }
}
