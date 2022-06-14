using System.Collections;

namespace Models
{
    public class Game
    {
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        // VARIABLES / PROPERTIES
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        public string? Name { get; set; }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        // METHODS
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        // Introduction
        // -------------
        public static void Introduction()
        {
            Console.WriteLine();
            Console.WriteLine("   Heroes Versus Monsters");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("   - Press any key to continue ... ");
            Console.ReadLine();
        }
        // Display Character Statistics
        // -----------------------------
        public static void DisplayCharStat(Character Player1)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("   ----------------------------------------------------");
            Console.WriteLine($"    STATISTICS :");
            Console.WriteLine("   ----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"   - Race :          \t {Player1.Race}");
            Console.WriteLine();
            Console.WriteLine($"   - Level :         \t {Player1.Level}");
            Console.WriteLine();
            Console.WriteLine($"   - Name :          \t {Player1.Name} :");
            Console.WriteLine($"   - Health Points : \t {Player1.Life} / {Player1.LifeMax}");
            Console.WriteLine($"   - Magic  Points : \t {Player1.Magic} / {Player1.MagicMax}");
            Console.WriteLine();
            Console.WriteLine($"   - Attack :        \t {Player1.AttackMax}");
            Console.WriteLine($"   - Defense :       \t {Player1.DefenseMax}");
            Console.WriteLine($"   - Endurance :     \t {Player1.StaminaMax}");
            Console.WriteLine();
            Console.WriteLine($"   - Money :         \t {Player1.Gold} gold coins.");
            Console.WriteLine();
            Console.WriteLine("   ----------------------------------------------------");
            Console.WriteLine($"    ITEMS :");
            Console.WriteLine("   ----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("   - Press a key to continue ... ");
            Console.ReadLine();
        }
        // Battle Start
        // -------------
        public static void BattleStart(Hero hero, Monster monster)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"   {hero.Name} Versus {monster.Name} !");
            Console.WriteLine();
            Console.WriteLine("   -----------------------------------------------------------------------------------");
            Console.WriteLine();

            bool battle_start = true;
            bool player_turn = true;

            while(battle_start || player_turn)
                {
                    if(hero.Life > 0 && player_turn)
                    {
                        hero.AttackChar(hero, monster);
                        player_turn = false;
                    }
                    else if(monster.Life > 0 && player_turn == false)
                    {
                        monster.AttackChar(monster, hero);
                        player_turn = true;
                    }
                    else if(hero.Life <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"   - ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(hero.Name);
                        Console.ResetColor();
                        Console.WriteLine($" has died !");
                        Console.WriteLine();
                        player_turn = false;
                        battle_start = false;
                    }
                    else if (monster.Life <= 0)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("   VICTORY !!!");
                        Console.WriteLine("  -------------");
                        Console.WriteLine();
                        Console.Write($"   - ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(monster.Name);
                        Console.ResetColor();
                        Console.Write($" has died !");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("   - Press any key to continue ... ");
                        Console.ReadLine();

                        hero.Gold += monster.Gold;
                        hero.Experience += 50;

                        // Display game menu
                        DisplayCharStat(hero);

                        // Hero Resting
                        Character.Rest(hero);

                        player_turn = false;
                        battle_start = false;
                    }
            }
        }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        // Generate Hero
        // --------------
        public static Hero GenerateHero()
        {
            Dictionary<int, string> menu_select_hero = new();
            menu_select_hero.Add(1, "play as a DWARF");
            menu_select_hero.Add(2, "play as a HUMAN");

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("   Select your Hero : ");
            Console.WriteLine("  --------------------");
            Console.WriteLine();
            Console.WriteLine("    HUMAN :      \t    DWARF :");
            Console.WriteLine("   --------------\t   ------------");
            Console.WriteLine("   - Attack  + 1");
            Console.WriteLine("   - Stamina + 1 \t   Stamina + 2");
            Console.WriteLine();
            Console.WriteLine();
            foreach (KeyValuePair<int, string> choice in menu_select_hero)
            {
                Console.Write($"   - Press ' ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{choice.Key}");
                Console.ResetColor();
                Console.Write($" ' to {choice.Value}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("   - Press any key to continue ... ");
            Console.ReadLine();

            Hero player1 = new Human("Human", 1, 0, "Player", 50, 20, 15, 15, 15, 500);

            return player1;
        }
        // Generate Monster
        // -----------------
        public static Monster GenerateMonster()
        {
            Monster monster = new Wolf("Monster", 1, 0, "Huggy Wuggy", 30, 10, 5, 5, 5, 30);

            return monster;
        }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        // Game Over Screen
        // -----------------
        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("   GAME OVER !");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("   - Press any key to close program ... ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}