using Tamagochi.Enumerator;

namespace Tamagochi.Base
{
    public class BaseTamagochi : AttributesTamagochi
    {
        protected string Name { get; set; }
        protected double Life { get; set; }

        protected double MaxLife;
  
        protected bool IsAlive { get; set; }

        protected EnumColorTamagochi Color { get; set; }

        private EnuRarityTamagochi _rarity = EnuRarityTamagochi.None;

        protected EnuRarityTamagochi Rarity 
        { 
            get 
            { 
                return _rarity; 
            } 
        }

        public void AddLife(int value)
        {
            Life += value;
        }

        public void RemoveLife(int value)
        {
            Life -= value;
        }

        protected void SetRarity(EnuRarityTamagochi rarity)
        {
            _rarity = rarity;
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

        protected virtual void AddAttributPoint(EnuAttributesTamagochi enuAtrribute, int valuePoint)
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
