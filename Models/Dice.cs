namespace Models
{
    public class Dice
    {
        // ----------------------------------------------------------------------------------------------------------------------
        // VARIABLES / PROPERTIES
        // ----------------------------------------------------------------------------------------------------------------------
        public int DiceMaximum { get; set; }        
        // ----------------------------------------------------------------------------------------------------------------------
        // CONSTRUCTOR
        // ----------------------------------------------------------------------------------------------------------------------
        public Dice(int dice_max)
        {
            DiceMaximum = dice_max;
        }
        // ----------------------------------------------------------------------------------------------------------------------
        // METHOD : DICE ROLL - STANDARD
        // ----------------------------------------------------------------------------------------------------------------------
        public static int DiceRoll(int max)
        {
            Random random = new();

            int dice = random.Next(1, max + 1);
            return dice;
        }
        // ----------------------------------------------------------------------------------------------------------------------
        // METHOD : DICE ROLL  - ATTACK
        // ----------------------------------------------------------------------------------------------------------------------
        public static int DiceRollAttack(Character character)
        {
            Random random = new();

            int dice_attack = random.Next(1, 5);

            Console.WriteLine();
            Console.Write($"   - {character.Name} gathers his energy :");
            Console.Write($" {character.Attack}"); Console.Beep(220, 100); Thread.Sleep(50);
            Console.Write(" +"); Console.Beep(220, 100); Thread.Sleep(50);
            Console.Write($" {dice_attack}"); Console.Beep(220, 100); Thread.Sleep(50);

            int total_attack = character.Attack + dice_attack;

            if (character.Attack < 5)
                {
                    total_attack -= 1;
                    Console.Write(" -"); Console.Beep(220, 100); Thread.Sleep(50);
                    Console.Write(" 1"); Console.Beep(220, 100); Thread.Sleep(50);
            }
            else if (character.Attack < 10)
                {

                }
            else if (character.Attack < 15)
                {
                    total_attack += 1;
                    Console.Write(" +"); Console.Beep(220, 100); Thread.Sleep(50);
                    Console.Write(" 1"); Console.Beep(220, 100); Thread.Sleep(50);
            }
            else
                {
                    total_attack += 2;
                    Console.Write(" +"); Console.Beep(220, 100); Thread.Sleep(50);
                    Console.Write(" 2"); Console.Beep(220, 100); Thread.Sleep(50);
            }

            Console.Write($" ="); Console.Beep(220, 100); Thread.Sleep(50);
            Console.Write($" {total_attack}"); Console.Beep(220, 100); Thread.Sleep(50);
            Console.WriteLine();

            return total_attack;
        }
    }
}