using Tamagochi.Enumerator;

namespace Tamagochi.Base
{
    public partial class BaseTamagochi
    {
        private EnumMoodTamagochi _mood;
        internal EnumMoodTamagochi Mood { get { return _mood;} }

        private EnumPersonalityTamagochi _personality = EnumPersonalityTamagochi.NoPersonality;

        internal EnumPersonalityTamagochi Personality { get { return _personality; } }

        internal void SetMood()
        {
            int randomMood = new Random().Next(0, 7);
            switch (randomMood)
            {
                case 0:
                    _mood = EnumMoodTamagochi.Neutral;
                    break;
                case 1:
                    _mood = EnumMoodTamagochi.Happy;
                    break;
                case 2:
                    _mood = EnumMoodTamagochi.Thinking;
                    break;
                case 3:
                    _mood = EnumMoodTamagochi.Excited;
                    break;
                case 4:
                    _mood = EnumMoodTamagochi.Surprised;
                    break;
                case 5:
                    _mood = EnumMoodTamagochi.Angry;
                    break;
                case 6:
                    _mood = EnumMoodTamagochi.Upset;
                    break;
                case 7:
                    _mood = EnumMoodTamagochi.Sleeping;
                    break;
            }
        }

        internal void SetPersonality()
        {
            int randomPersonality = new Random().Next(0, 10);
            switch (randomPersonality)
            {
                case 0:
                    _personality = EnumPersonalityTamagochi.NoPersonality;
                    break;
                case 1:
                    _personality = EnumPersonalityTamagochi.Gentle;
                    break;
                case 2:
                    _personality = EnumPersonalityTamagochi.Energetic;
                    break;
                case 3:
                    _personality = EnumPersonalityTamagochi.Quiet;
                    break;
                case 4:
                    _personality = EnumPersonalityTamagochi.BigEater;
                    break;
                case 5:
                    _personality = EnumPersonalityTamagochi.EasilyBored;
                    break;
                case 6:
                    _personality = EnumPersonalityTamagochi.Curious;
                    break;
                case 7:
                    _personality = EnumPersonalityTamagochi.Carefree;
                    break;
                case 8:
                    _personality = EnumPersonalityTamagochi.CryBaby;
                    break;
                case 9:
                    _personality = EnumPersonalityTamagochi.Lonely;
                    break;
            }
        }
    }
}
