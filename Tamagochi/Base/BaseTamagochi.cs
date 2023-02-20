using Tamagochi.Enumerator;

namespace Tamagochi.Base
{
    public class BaseTamagochi : AttributesTamagochi
    {
        internal string Name { get; set; }
        internal double Life { get; set; }

        private double _maxLife = 0;
        internal double MaxLife 
        {
            get
            {
                return _maxLife;
            } 
        }
  
        private bool _isAlive = false;
        internal bool IsAlive 
        {
            get
            {
                return _isAlive;
            }
        }

        private EnumMood _mood = EnumMood.Neutral;
        internal EnumMood Mood
        {
            get
            {
                return _mood;
            }
        }

        private EnumLifeCircle _lifeCircle = EnumLifeCircle.Child;
        internal EnumLifeCircle LifeCircle
        {
            get 
            {
                return _lifeCircle;    
            }
        }

        internal EnumColorTamagochi Color { get; set; }

        private EnumRarityTamagochi _rarity = EnumRarityTamagochi.None;
        internal EnumRarityTamagochi Rarity 
        { 
            get 
            { 
                return _rarity; 
            } 
        }

        internal void AddLife(int value)
        {
            Life += value;
        }

        internal void RemoveLife(int value)
        {
            Life -= value;
        }

        internal void SetRarity(EnumRarityTamagochi rarity)
        {
            _rarity = rarity;
        }

        internal void SetLifeCircle(EnumLifeCircle lifeCircle)
        {
            _lifeCircle = lifeCircle;
        }

        internal void SetMood(EnumMood mood)
        {
            _mood = mood;
        }
        internal void SetIsAlive(bool isAlive)
        {
            _isAlive = isAlive;
        }
        internal void SetMaxLife(double maxLife)
        {
            _maxLife = maxLife;
        }

        internal virtual void AddLevelAttribut(EnuAttributesTamagochi enuAtrribute)
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
                        _maxLife += _maxLife * 0.5; 
                    }
                    break;
            }
        }

        internal virtual void AddPointAttribute(EnuAttributesTamagochi enuAtrribute, int valuePoint)
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
