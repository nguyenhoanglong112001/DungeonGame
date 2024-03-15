using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdvntureGame
{
    public delegate void CreateHero(string name);
    internal class Program
    {
        public static CreateHero createhero;
        public static UIManager uimanager = null;
        public static Hero hero = null;
        public static CharacterManager characterManager = null;
        public static AccountInformation accountinfo = null;
        static void Main(string[] args)
        {
            uimanager = new UIManager();
            characterManager = new CharacterManager();
            accountinfo = new AccountInformation();
            uimanager.LoginUI();
        }
    }
}
