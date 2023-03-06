using Tamagochi.Base;
using Tamagochi.Enumerator;

namespace Tamagochi.Tamagochis
{
    public class SuperRareTamagochi : BaseTamagochi
    {
        public SuperRareTamagochi(string name, int life)
        {
            Name = name;
            SetIsAlive(true);
            Life = life;
            SetMaxLife(life);
            SetRandomPersonality();
            SetRandomMood();
            SetRandomColor();
            SetRarity(EnumRarityTamagochi.SuperRare);
        }
    }
}
