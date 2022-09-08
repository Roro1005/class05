using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode05
{
    public abstract class Character
    {
        public float HP
        {
            get;
            private set;
        }
        public float MaxHP
        {
            get;
            private set;
        }
        public float AttackPoint
        {
            get;
            private set;
        }
        public float DefencePoint
        {
            get;
            private set;
        }

        public Character(float maxHP, float attackPoint, float defencePoint)
        {
            this.MaxHP = maxHP;
            this.HP = maxHP;
            this.AttackPoint = attackPoint;
            this.DefencePoint = defencePoint;
        }

        public abstract void WriteProfile();
        public void Attack(Character target)
        {
            //ダメージ計算
            float damage = this.AttackPoint - target.DefencePoint;
            if(damage < 0) damage = 0;

            //相手のHPを減らす
            target.HP -= damage;
        }
       
    }
}
