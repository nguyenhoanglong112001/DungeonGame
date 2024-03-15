using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class CharacterManager
    {
        Character character = null;

        public CharacterManager() 
        {
            Program.createhero = CreateHero; 
        }

        public HeroType ChooseType()
        {
            int str = Program.uimanager.InputInt("Nhap lua chon cua ban: ");
            HeroType herotype = 0;
            if (str == 1)
            {
                herotype = HeroType.Tank;
            }
            else if (str == 2)
            {
                herotype = HeroType.Ranged;
            }
            else if (str == 3)
            {
                herotype = HeroType.Assasin;
            }
            return herotype;
        }
        public void CreateHero(string name)
        {
            HeroType type = ChooseType();
            if (type == HeroType.Tank)
            {
                Program.hero = new Tanker(name, type);
            }
            else if (type == HeroType.Ranged)
            {
                Program.hero = new Ranged(name, type);
            }
            else if (type == HeroType.Assasin)
            {
                Program.hero = new Assasin(name, type);
            }
        }
    }


}
