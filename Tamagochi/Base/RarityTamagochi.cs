using Tamagochi.Enumerator;

namespace Tamagochi.Base
{
    public partial class BaseTamagochi
    {

        private EnumRarityTamagochi _rarity = EnumRarityTamagochi.None;
        internal EnumRarityTamagochi Rarity { get { return _rarity; } }
        internal void SetRarity(EnumRarityTamagochi rarity)
        {
            _rarity = rarity;
        }
    }
}
