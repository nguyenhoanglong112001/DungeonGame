using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvntureGame
{
    public class UIManager
    {
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("=========Dungeon Game==========");
            Console.WriteLine("1. Create Hero");
            Console.WriteLine("2. Show hero infomation");
            int str = InputInt("Lua chon cua ban: ");
            if (str == 1)
            {
                CreateHeroUI();
            }
            else if (str == 2)
            {
                ShowHeroInfo();
            }
        }
        public void LoginUI()
        {
            Console.Clear();
            Console.WriteLine("1. Dang nhap");
            Console.WriteLine("2. Dang ky");
            int select = InputInt("Lua chon cua ban: ");
            if (select == 1)
            {
                Login();
            }
            else if (select == 2 )
            {
                Register();
            }
        }
        public void Register()
        {
            Console.Clear();
            Console.WriteLine("=======Dang ky tai khoan=======");
            string json = File.ReadAllText("Data.json");
            Data data = JsonConvert.DeserializeObject<Data>(json);
            string username = InputStr("username: ");
            string password = InputStr("Password: ");
            foreach (var kvp in data.account.Values)
            {
                if (username.Equals(kvp.username))
                {
                    Console.WriteLine("Ten dang nhap da ton tai vui long nhap lai");
                    Console.ReadKey();
                    LoginUI();
                }
            }
            Program.accountinfo.account = new Account(username, password);
            data.account.Add(username, Program.accountinfo.account);
            string newjson = JsonConvert.SerializeObject(data);
            File.WriteAllText("Data.json", newjson);
            Console.WriteLine("Tao tai khoan moi thanh cong");
            Console.ReadKey();
            LoginUI();
        }

        public void Login()
        {
            Console.Clear();
            string json = File.ReadAllText("Data.json");
            Data data = JsonConvert.DeserializeObject<Data>(json);
            Console.WriteLine("=======Dang nhap=======");
            string username = InputStr("username: ");
            string password = InputStr("Password: ");
            if (data.account.Any(u => u.Value.username.Equals(username) && u.Value.password.Equals(password)))
            {
                Console.WriteLine("Dang nhap thanh cong");
                Console.ReadKey();
                MainMenu();
            }
            else
            {
                Console.WriteLine("Sai ten tai khoan hoac mat khau");
                Console.ReadKey();
                LoginUI();
            }
        }

        public void ChooseTypeUI()
        {
            Console.Clear();
            Console.WriteLine("1. Tanker");
            Console.WriteLine("2. Ranged");
            Console.WriteLine("3. Assasin");
            Program.characterManager.ChooseType();
        }
        
        public void CreateHeroUI()
        {
            Console.Clear();
            Console.WriteLine("=======Khoi tao nhan vat==========");
            string name = InputStr("Ten nhan vat: ");
            ChooseTypeUI();
            Program.createhero(name);
            Program.accountinfo.characters.Add(Program.hero);
            Console.WriteLine("Tao nhan vat thanh cong");
            Console.ReadKey();
            MainMenu();
        }

        public void ShowHeroInfo()
        {
            Console.Clear();
            Console.WriteLine($"========{Program.hero.name}'information=========");
            Console.WriteLine($"Type: {Program.hero.type}");
            Console.WriteLine($"Level {Program.hero.level} \t Exp: {Program.hero.exp} \t Gold: {Program.hero.currentgold}");
            Console.WriteLine($"HP: {Program.hero.hp}");
            Console.WriteLine($"Mana: {Program.hero.mp}");
            Console.WriteLine($"Attack dame: {Program.hero.atk}");
            Console.WriteLine($"Attack speed: {Program.hero.atkspeed}");
            Console.WriteLine($"Amplify Dame: {Program.hero.ap}");
            Console.WriteLine($"Amor: {Program.hero.amor}");
            Console.WriteLine($"Crit: {Program.hero.crit}");
            Console.WriteLine($"Evasion: {Program.hero.evasion}");
            Console.WriteLine($"Accurancy: {Program.hero.accurancy}");
            Console.ReadKey();
            MainMenu();
        }

        public string InputStr(string input)
        {
            Console.Write(input);
            return Console.ReadLine();
        }

        public int InputInt (string input)
        {
            Console.Write(input);
            return int.Parse(Console.ReadLine());
        }
    }
}
