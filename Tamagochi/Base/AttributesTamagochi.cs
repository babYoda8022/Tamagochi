
namespace Tamagochi.Base
{
    public class AttributesTamagochi
    {
        private int _swimLevel = 1;
        protected int SwimLevel { 
            get
            {
                return _swimLevel;
            } }

        private int _flyLevel = 1;

        protected int FlyLevel { 
            get
            {
                return _flyLevel;
            } }

        private int _runLevel = 1;
        protected int RunLevel
        {
            get
            {
                return _runLevel;
            }
        }

        private int _powerLevel = 1;
        protected int PowerLevel { 
            get
            {
                return _powerLevel;
            } }

        private int _staminaLevel = 1;
        protected int StaminaLevel
        {
            get
            {
                return _staminaLevel;
            }
        }
        protected int SwimPoints { get; set; }
        protected int FlyPoints { get; set; }
        protected int RunPoints { get; set; }
        protected int PowerPoints { get; set; }
        protected int StaminaPoints { get; set; }

        protected void SetSwin()
        {
            _swimLevel++;
        }
        protected void SetFly()
        {
            _flyLevel++;
        }
        protected void SetRun()
        {
            _runLevel++;
        }
        protected void SetPower()
        {
            _powerLevel++;
        }
        protected void SetStamina()
        {
            _staminaLevel++;
        }
    }
}
