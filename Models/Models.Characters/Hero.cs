namespace Models
{
    public class Hero : Character
    {
        public Hero(string race, int level, int experience, string name, int lifemax, int magicmax, int attackmax, int defensemax, int staminamax, uint gold) : base(race, level, experience, name, lifemax, magicmax, attackmax, defensemax, staminamax, gold)
        {

        }
    }
}