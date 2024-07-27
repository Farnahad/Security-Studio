using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.Vega.ViewModel
{
    public class SsVegaViewModel : SsViewModel
    {
        public SsCommand SsShowVegaCommand { get; set; }
        public SsCommand SsOpenVegaCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowVegaCommand = new SsCommand(SsShowVega);
            SsOpenVegaCommand = new SsCommand(SsOpenVega);
        }

        private void SsShowVega(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenVega(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Vega";
            Uri = _uriAddress = "https://subgraph.com/vega/";
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