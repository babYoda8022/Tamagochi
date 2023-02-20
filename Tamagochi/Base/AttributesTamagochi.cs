
namespace Tamagochi.Base
{
    public class AttributesTamagochi
    {
        private int _swimLevel = 1;
        internal int SwimLevel { 
            get
            {
                return _swimLevel;
            } }

        private int _flyLevel = 1;

        internal int FlyLevel { 
            get
            {
                return _flyLevel;
            } }

        private int _runLevel = 1;
        internal int RunLevel
        {
            get
            {
                return _runLevel;
            }
        }

        private int _powerLevel = 1;
        internal int PowerLevel { 
            get
            {
                return _powerLevel;
            } }

        private int _staminaLevel = 1;
        internal int StaminaLevel
        {
            get
            {
                return _staminaLevel;
            }
        }
        private int _swimPoints = 0;
        internal int SwimPoints 
        { get 
            {
                return _swimPoints;
            } 
        }
        private int _flyPoints = 0;
        internal int FlyPoints
        {
            get
            {
                return _flyPoints;
            }
        }
        private int _runPoints = 0;
        internal int RunPoints
        {
            get
            {
                return _runPoints;
            }
        }
        private int _powerPoints = 0;
        internal int PowerPoints
        {
            get
            {
                return _powerPoints;
            }
        }
        private int _staminaPoints = 0;
        internal int StaminaPoints
        {
            get
            {
                return _staminaPoints;
            }
        }

        internal void SetSwin()
        {
            _swimLevel++;
        }
        internal void SetFly()
        {
            _flyLevel++;
        }
        internal void SetRun()
        {
            _runLevel++;
        }
        internal void SetPower()
        {
            _powerLevel++;
        }
        internal void SetStamina()
        {
            _staminaLevel++;
        }

        internal void SetSwinPoints(int valuePoints)
        {
            _swimPoints+= valuePoints;
        }
        internal void SetFlyPoints(int valuePoints)
        {
            _flyPoints+= valuePoints;
        }
        internal void SetRunPoints(int valuePoints)
        {
            _runPoints+= valuePoints;
        }
        internal void SetPowerPoints(int valuePoints)
        {
            _powerPoints+= valuePoints;
        }
        internal void SetStaminaPoints(int valuePoints)
        {
            _staminaPoints+= valuePoints;
        }
    }
}
