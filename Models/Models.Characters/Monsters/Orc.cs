namespace Models
{
    public class Orc : Monster
    {
        public Orc(string race, int level, int experience, string name, int lifemax, int magicmax, int attackmax, int defensemax, int staminamax, uint gold) : base(race, level, experience, name, lifemax, magicmax, attackmax, defensemax, staminamax, gold)
        {

        }
    }
}