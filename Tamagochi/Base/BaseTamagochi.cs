using Tamagochi.Enumerator;

namespace Tamagochi.Base
{
    public partial class BaseTamagochi
    {
        internal string? Name { get; set; }
        internal int Life { get; set; }

        private int _maxLife = 0;
        internal int MaxLife { get { return _maxLife; } }

        private bool _isAlive = false;
        internal bool IsAlive { get { return _isAlive; } }

        private EnumLifeCircleTamagochi _lifeCycle = EnumLifeCircleTamagochi.Child;
        internal EnumLifeCircleTamagochi LifeCycle { get { return _lifeCycle; } }
        internal void AddLife(int value)
        {
            int difLifeMaxlife = MaxLife - Life;

            if (value <= difLifeMaxlife)
                Life += value;
            else
                Life += difLifeMaxlife;
        }
        internal void RemoveLife(int value)
        {
            if (value >= Life)
            {
                Life -= value;
                SetIsAlive(false);
            }
            Life -= value;
        }
        internal void SetLifeCycle(EnumLifeCircleTamagochi lifeCircle)
        {
            _lifeCycle = lifeCircle;
        }
        internal void SetIsAlive(bool isAlive)
        {
            _isAlive = isAlive;
        }
        internal void SetMaxLife(int maxLife)
        {
            _maxLife = maxLife;
        }
    }
}
