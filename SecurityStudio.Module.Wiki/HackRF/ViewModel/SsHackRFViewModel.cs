using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.HackRF.ViewModel
{
    public class SsHackRFViewModel : SsViewModel
    {
        public SsCommand SsShowHackRFCommand { get; set; }
        public SsCommand SsOpenHackRFCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowHackRFCommand = new SsCommand(SsShowHackRF);
            SsOpenHackRFCommand = new SsCommand(SsOpenHackRF);
        }

        private void SsShowHackRF(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenHackRF(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "HackRF";
            Uri = _uriAddress = "https://greatscottgadgets.com/hackrf/";
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