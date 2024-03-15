using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class Hero : Character
    {
        public override string name { get; set; }
        public override HeroType type { get; set; }
        public override int hp { get; set; }
        public override int mp { get; set; }
        public override int atk { get; set; }
        public override int ap { get; set; }
        public override int atkspeed {  get; set; }
        public override int amor { get; set; }
        public override int crit { get; set; }
        public override int evasion { get; set; }
        public override int accurancy { get; set; }
        public override int level { get; set; }
        public override int exp { get; set; }
        public override int currentgold { get; set; }

        public Hero(string name, HeroType type)
        {
            this.name = name;
            this.type = type;
            this.level = 1;
            this.exp = 0;
            this.currentgold = 0;
        }
        public override void Attack()
        {
          
        }

        public override void UseSkill()
        {
            
        }

        public override void Skill()
        {

        }
    }
}
