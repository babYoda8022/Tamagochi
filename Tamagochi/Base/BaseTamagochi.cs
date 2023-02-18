using Tamagochi.Enumerator;

namespace Tamagochi.Base
{
    public class BaseTamagochi : AttributesTamagochi
    {
        protected string Name { get; set; }
        protected double Life { get; set; }

        protected double MaxLife;
  
        protected bool IsAlive { get; set; }

        protected enumColorTamagochi Color { get; set; }

        private enuRarityTamagochi _rarity = enuRarityTamagochi.None;

        protected enuRarityTamagochi Rarity 
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

        protected void SetRarity(enuRarityTamagochi rarity)
        {
            _rarity = rarity;
        }

        protected virtual void AddLevelAttribut(enuAttributesTamagochi enuAtrribute)
        {
            switch (enuAtrribute)
            {
                case enuAttributesTamagochi.Swim:
                    if (SwimPoints > SwimLevel * 64)
                    {
                        SetSwin();
                    }
                    break;

                case enuAttributesTamagochi.Fly:
                    if (FlyPoints > FlyLevel * 64)
                    {
                        SetFly();
                    }
                    break;

                case enuAttributesTamagochi.Run:
                    if (RunPoints > RunLevel * 64)
                    {
                        SetRun();
                    }
                    break;

                case enuAttributesTamagochi.Power:
                    if (PowerPoints > PowerLevel * 64)
                    {
                        SetPower();
                    }
                    break;

                case enuAttributesTamagochi.Stamina:
                    if (StaminaPoints > StaminaLevel * 64)
                    {
                        SetStamina();
                        MaxLife += MaxLife * 0.5; 
                    }
                    break;
            }
        }

    }
}
