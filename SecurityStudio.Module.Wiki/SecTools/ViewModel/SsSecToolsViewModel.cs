using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.SecTools.ViewModel
{
    public class SsSecToolsViewModel : SsViewModel
    {
        public SsCommand SsShowSecToolsCommand { get; set; }
        public SsCommand SsOpenSecToolsCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowSecToolsCommand = new SsCommand(SsShowSecTools);
            SsOpenSecToolsCommand = new SsCommand(SsOpenSecTools);
        }

        private void SsShowSecTools(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenSecTools(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "SecTools";
            Uri = _uriAddress = "https://sectools.org/";
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