using Tamagochi.Base;

namespace Tamagochi.Tamagochis
{
    public class StandardTamagochi : BaseTamagochi
    {
       public StandardTamagochi(string name, int life)
       {
            Name = name;
            SetIsAlive(true);
            Life = life;
            SetMaxLife(life);
            SetRandomPersonality();
            SetRandomMood();
            SetRandomColor();
       }
    }
}
