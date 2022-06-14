namespace Models
{
    public class Dwarf : Hero
    {
        public Dwarf(string race, int level, int experience, string name, int lifemax, int magicmax, int attackmax, int defensemax, int staminamax, uint gold) : base(race, level, experience, name, lifemax, magicmax, attackmax, defensemax, staminamax, gold)
        {

        }
    }
}