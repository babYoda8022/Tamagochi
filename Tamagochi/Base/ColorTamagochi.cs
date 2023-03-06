using Tamagochi.Enumerator;

namespace Tamagochi.Base
{
    public partial class BaseTamagochi
    {
        internal EnumColorTamagochi _color = EnumColorTamagochi.Blue;
        internal EnumColorTamagochi Color { get { return _color; } }

        internal void SetRandomColor()
        {
            int randomColor = new Random().Next(0, 4);
            _color = (EnumColorTamagochi)randomColor;
        }
    }
}
