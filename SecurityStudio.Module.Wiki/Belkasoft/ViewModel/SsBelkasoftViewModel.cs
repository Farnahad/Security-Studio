using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Belkasoft.ViewModel
{
    public class SsBelkasoftViewModel : SsViewModel
    {
        public SsCommand SsShowBelkasoftCommand { get; set; }
        public SsCommand SsOpenBelkasoftCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowBelkasoftCommand = new SsCommand(SsShowBelkasoft);
            SsOpenBelkasoftCommand = new SsCommand(SsOpenBelkasoft);
        }

        private void SsShowBelkasoft(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenBelkasoft(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Belkasoft";
            Uri = _uriAddress = "https://belkasoft.com/";
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