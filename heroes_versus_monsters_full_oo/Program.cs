// ------------------------------------------------------------------------------------------------------------------------------------------------------
// FLYING PAD | C# | HEROES VERSUS MONSTERS
// ------------------------------------------------------------------------------------------------------------------------------------------------------
using Models;

namespace heroes_vs_monsters_full_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Window title
            Console.Title = "Heroes Vs Monsters";

            // Game introduction
            Game.Introduction();

            // Generate Hero
            Hero Hero = Game.GenerateHero();

            // Display game menu
            Game.DisplayCharStat(Hero);

            // Generate monster
            Monster Monster = Game.GenerateMonster();

            // Display game menu
            Game.DisplayCharStat(Monster);

            // Battle start
            Game.BattleStart(Hero, Monster);

            // Display game over screen
            Game.GameOver();
        }
    }
}