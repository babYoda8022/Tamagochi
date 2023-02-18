using Tamagochi.Base;
using Tamagochi.Enumerator;

namespace Tamagochi.Tamagochis
{
    public class StandardTamagochi : BaseTamagochi
    {
        public StandardTamagochi(string name, double life, enumColorTamagochi color) 
        {
            Name = name;
            MaxLife = life;
            Life = life;
            IsAlive = true;
            Color = color;
        }
    }
}
