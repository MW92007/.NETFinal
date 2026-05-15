using ConsoleRpgEntities.Models.Attributes;

namespace ConsoleRpgEntities.Models.Characters.Monsters
{
    public class Slime : Monster
    {

        public int GelatinousBile { get; set; }

        public override void Attack(ITargetable target)
        {
            
            for (int i = 1; i <= GelatinousBile; i++)
            {
                target.Health -= 5 * i;
                Console.WriteLine($"{Name} melds into {target.Name} acidically dealing {5 * i} damage!");
            }
        }

    }
}
