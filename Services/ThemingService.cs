namespace portfolio.Services
{
    public class ThemingService
    {
        private bool _lightMode = false;
        public bool LightMode
        {
            get
            {
                return _lightMode;
            }
            set
            {
                _lightMode = value;
                OnChanged?.Invoke();
            }
        }
        public event Action? OnChanged;
    }
}

