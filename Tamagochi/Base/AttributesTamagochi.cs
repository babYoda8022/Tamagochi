
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
        private int _swimPoints = 0;
        protected int SwimPoints 
        { get 
            {
                return _swimPoints;
            } 
        }
        private int _flyPoints = 0;
        protected int FlyPoints
        {
            get
            {
                return _flyPoints;
            }
        }
        private int _runPoints = 0;
        protected int RunPoints
        {
            get
            {
                return _runPoints;
            }
        }
        private int _powerPoints = 0;
        protected int PowerPoints
        {
            get
            {
                return _powerPoints;
            }
        }
        private int _staminaPoints = 0;
        protected int StaminaPoints
        {
            get
            {
                return _staminaPoints;
            }
        }

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

        protected void SetSwinPoints(int valuePoints)
        {
            _swimPoints+= valuePoints;
        }
        protected void SetFlyPoints(int valuePoints)
        {
            _flyPoints+= valuePoints;
        }
        protected void SetRunPoints(int valuePoints)
        {
            _runPoints+= valuePoints;
        }
        protected void SetPowerPoints(int valuePoints)
        {
            _powerPoints+= valuePoints;
        }
        protected void SetStaminaPoints(int valuePoints)
        {
            _staminaPoints+= valuePoints;
        }
    }
}
