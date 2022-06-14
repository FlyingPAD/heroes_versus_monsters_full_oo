namespace Models
{
    public class Wolf : Monster
    {
        public Wolf(string race, int level, int experience, string name, int lifemax, int magicmax, int attackmax, int defensemax, int staminamax, uint gold) : base(race, level, experience, name, lifemax, magicmax, attackmax, defensemax, staminamax, gold)
        {

        }
    }
}