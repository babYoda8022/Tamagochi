using Tamagochi.Enumerator;

namespace Tamagochi.Base
{
    public partial class ColorTamagochi
    {
        internal EnumColorTamagochi _color = EnumColorTamagochi.Blue;
        internal EnumColorTamagochi Color { get { return _color; } }

        internal void SetColor(EnumColorTamagochi color)
        {
            _color = color;
        }
    }
}
