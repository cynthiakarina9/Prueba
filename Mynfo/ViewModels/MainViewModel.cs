namespace Mynfo.ViewModels
{
    public class MainViewModel
    {
        #region viewModels
        public LoginViewModel Login { get; set; }
        #endregion
        #region Constructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion

    }
}