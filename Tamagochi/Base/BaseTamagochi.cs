using Tamagochi.Enumerator;

namespace Tamagochi.Base
{
    public class BaseTamagochi : AttributesTamagochi
    {
        protected string Name { get; set; }
        protected double Life { get; set; }

        protected double MaxLife;
  
        protected bool IsAlive { get; set; }

        private EnumMood _mood = EnumMood.Neutral;
        protected EnumMood Mood
        {
            get
            {
                return _mood;
            }
        }

        private EnumLifeCircle _lifeCircle = EnumLifeCircle.Child;
        private EnumLifeCircle LifeCircle
        {
            get 
            {
                return _lifeCircle;    
            }
        }

        protected EnumColorTamagochi Color { get; set; }

        private EnumRarityTamagochi _rarity = EnumRarityTamagochi.None;
        protected EnumRarityTamagochi Rarity 
        { 
            get 
            { 
                return _rarity; 
            } 
        }

        protected void AddLife(int value)
        {
            Life += value;
        }

        protected void RemoveLife(int value)
        {
            Life -= value;
        }

        protected void SetRarity(EnumRarityTamagochi rarity)
        {
            _rarity = rarity;
        }

        protected void SetLifeCircle(EnumLifeCircle lifeCircle)
        {
            _lifeCircle = lifeCircle;
        }

        protected void SetMood(EnumMood mood)
        {
            _mood = mood;
        }

        protected virtual void AddLevelAttribut(EnuAttributesTamagochi enuAtrribute)
        {
            switch (enuAtrribute)
            {
                case EnuAttributesTamagochi.Swim:
                    if (SwimPoints > SwimLevel * 64)
                    {
                        SetSwin();
                    }
                    break;

                case EnuAttributesTamagochi.Fly:
                    if (FlyPoints > FlyLevel * 64)
                    {
                        SetFly();
                    }
                    break;

                case EnuAttributesTamagochi.Run:
                    if (RunPoints > RunLevel * 64)
                    {
                        SetRun();
                    }
                    break;

                case EnuAttributesTamagochi.Power:
                    if (PowerPoints > PowerLevel * 64)
                    {
                        SetPower();
                    }
                    break;

                case EnuAttributesTamagochi.Stamina:
                    if (StaminaPoints > StaminaLevel * 64)
                    {
                        SetStamina();
                        MaxLife += MaxLife * 0.5; 
                    }
                    break;
            }
        }

        protected virtual void AddPointAttribute(EnuAttributesTamagochi enuAtrribute, int valuePoint)
        {
            switch (enuAtrribute)
            {
                case EnuAttributesTamagochi.Swim:
                    SetSwinPoints(valuePoint);
                    break;

                case EnuAttributesTamagochi.Fly:
                    SetFlyPoints(valuePoint);
                    break;

                case EnuAttributesTamagochi.Run:
                    SetRunPoints(valuePoint);
                    break;

                case EnuAttributesTamagochi.Power:
                    SetPowerPoints(valuePoint);
                    break;

                case EnuAttributesTamagochi.Stamina:
                    SetStaminaPoints(valuePoint);
                    break;
            }
        }

    }
}
