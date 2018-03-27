using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace ClassLibrary1.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel()
        {
            Photos = new MvxObservableCollection<Photo>
            {
                new Photo()
                {
                    Url = "https://icdn.2cda.pl/obr/oryginalne/850ca7d90566b9ed82c60d9d50771230.jpg"
                }
            };
        }
        
        public MvxObservableCollection<Photo> Photos { get; }
        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }
        
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}