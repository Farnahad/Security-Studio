using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.FernWifiCracker.ViewModel
{
    public class SsFernWifiCrackerViewModel : SsViewModel
    {
        public SsCommand SsShowFernWifiCrackerCommand { get; set; }
        public SsCommand SsOpenFernWifiCrackerCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowFernWifiCrackerCommand = new SsCommand(SsShowFernWifiCracker);
            SsOpenFernWifiCrackerCommand = new SsCommand(SsOpenFernWifiCracker);
        }

        private void SsShowFernWifiCracker(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenFernWifiCracker(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "Fern Wifi Cracker";
            Uri = _uriAddress = "https://github.com/savio-code/fern-wifi-cracker/";
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