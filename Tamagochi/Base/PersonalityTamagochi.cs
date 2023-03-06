using Tamagochi.Enumerator;

namespace Tamagochi.Base
{
    public partial class BaseTamagochi
    {
        private EnumMoodTamagochi _mood;
        internal EnumMoodTamagochi Mood { get { return _mood;} }

        private EnumPersonalityTamagochi _personality = EnumPersonalityTamagochi.NoPersonality;
        internal EnumPersonalityTamagochi Personality { get { return _personality; } }

        internal void SetRandomMood()
        {
            int randomMood = new Random().Next(0, 7);
            _mood = (EnumMoodTamagochi)randomMood;
        }
        internal void SetRandomPersonality()
        {
            int randomPersonality = new Random().Next(0, 10);
            _personality = (EnumPersonalityTamagochi)randomPersonality;
        }
    }
}
