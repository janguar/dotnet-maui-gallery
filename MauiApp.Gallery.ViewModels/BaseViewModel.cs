namespace MauiApp.Gallery.ViewModels
{
    public class BaseViewModel<T> where T : class, new()
    {

        private readonly T _viewModel;

        public BaseViewModel()
        {
            _viewModel = new T();
        }

    }
}
