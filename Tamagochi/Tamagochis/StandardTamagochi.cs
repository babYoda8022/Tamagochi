using Tamagochi.Base;
using Tamagochi.Enumerator;

namespace Tamagochi.Tamagochis
{
    public class StandardTamagochi : BaseTamagochi
    {
        public StandardTamagochi(string name, double maxLife, EnumColorTamagochi color) 
        {
            Name = name;
            MaxLife= maxLife;
            Life = maxLife;
            IsAlive = true;
            Color = color;
        }
    }
}
