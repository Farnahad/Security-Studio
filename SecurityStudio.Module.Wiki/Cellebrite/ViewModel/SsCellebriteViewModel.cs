using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Cellebrite.ViewModel
{
    public class SsCellebriteViewModel : SsViewModel
    {
        public SsCommand SsShowCellebriteCommand { get; set; }
        public SsCommand SsOpenCellebriteCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowCellebriteCommand = new SsCommand(SsShowCellebrite);
            SsOpenCellebriteCommand = new SsCommand(SsOpenCellebrite);
        }

        private void SsShowCellebrite(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenCellebrite(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Cellebrite";
            Uri = _uriAddress = "https://cellebrite.com/en/home/";
            _utilityTool = new UtilityTool();
        }

        protected override void FillData()
        {
        }

        private string _uri;
        public string Uri
        {
            get => _uri;
            set
            {
                _uri = value;
                OnPropertyChanged();
            }
        }

        public override void Dispose()
        {
        }
    }
}