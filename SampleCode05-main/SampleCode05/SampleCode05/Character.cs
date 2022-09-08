using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode05
{
    public class Character
    {
        public float HP;
        public float MaxHP;
        public float AttackPoint;
        public float DefencePoint;

        public Character(float maxHP, float attackPoint, float defencePoint)
        {
            this.MaxHP = maxHP;
            this.HP = maxHP;
            this.AttackPoint = attackPoint;
            this.DefencePoint = defencePoint;
        }

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
