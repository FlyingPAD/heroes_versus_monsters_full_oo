namespace Models
{
    public class Character
    {
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        // VARIABLES / PROPERTIES
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        public string? Race { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public string? Name { get; set; }
        public int Life { get; set; }
        public int LifeMax { get; set; }
        public int Magic { get; set; }
        public int MagicMax { get; set; }
        public int Attack { get; set; }
        public int AttackMax { get; set; }
        public int Defense { get; set; }
        public int DefenseMax { get; set; }
        public int Stamina { get; set; }
        public int StaminaMax { get; set; }
        public uint Gold { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        // CONSTRUCTOR
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        public Character(string race, int level, int experience, string name, int lifemax, int magicmax, int attackmax, int defensemax, int staminamax, uint gold)
        {
            Race = race;
            Level = level;
            Experience = experience;
            Name = name;            
            LifeMax = lifemax;
            Life = lifemax;
            MagicMax = magicmax;
            Magic = magicmax;
            AttackMax = attackmax;
            Attack = attackmax;
            DefenseMax = defensemax;
            Defense = defensemax;
            StaminaMax = staminamax;
            Stamina = staminamax;
            Gold = gold;
        }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        // METHOD : ATTACK - STANDARD
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        public virtual void AttackChar(Character char_1, Character char_2)
        {
            int dice_attack = Dice.DiceRollAttack(char_1);

            char_2.Life -= dice_attack;

            Console.WriteLine();
            Console.Write($"   - {char_1.Name} hits {char_2.Name} : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(dice_attack);
            Console.ResetColor();
            Console.Write(" Damage.");
            Console.WriteLine();
            Console.Write("   "); Console.Beep(110, 400); Thread.Sleep(400);
            Console.ReadLine();
        }
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        // METHOD : REST ( Total Regeneration )
        // ------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void Rest(Character character)
        {
            character.Life = character.LifeMax;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"   - {character.Name} is taking a break !");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("   - Press any key to continue ... ");
            Console.ReadLine();

            // Display game menu
            Game.DisplayCharStat(character);
        }
    }
}