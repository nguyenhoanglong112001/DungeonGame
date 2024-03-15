using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public abstract class Character
    {
        public abstract string name {  get; set; }
        public abstract HeroType type { get; set; }
        public abstract int hp {  get; set; }
        public abstract int mp { get; set; }
        public abstract int atk {  get; set; }
        public abstract int atkspeed {  get; set; }
        public abstract int ap { get; set; }
        public abstract  int amor { get; set; }
        public abstract int crit { get; set; }
        public  abstract int evasion { get; set; }
        public  abstract int accurancy { get; set; }
        public  abstract int level { get; set; }
        public  abstract int exp {  get; set; }
        public  abstract int currentgold { get; set; }

        public abstract void Attack();

        public abstract void UseSkill();

        public abstract void Skill();
    }
}
