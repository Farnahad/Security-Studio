using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Base.Tool.Utility;

namespace SecurityStudio.Module.Wiki.NetworkMiner.ViewModel
{
    public class SsNetworkMinerViewModel : SsViewModel
    {
        public SsCommand SsShowNetworkMinerCommand { get; set; }
        public SsCommand SsOpenNetworkMinerCommand { get; set; }

        protected override void PrepareSsCommands()
        {
            SsShowNetworkMinerCommand = new SsCommand(SsShowNetworkMiner);
            SsOpenNetworkMinerCommand = new SsCommand(SsOpenNetworkMiner);
        }

        private void SsShowNetworkMiner(object parameter)
        {
            Uri = _uriAddress;
        }

        private void SsOpenNetworkMiner(object parameter)
        {
            _utilityTool.OpenUrlInDefaultBrowser(_uriAddress);
        }

        private string _uriAddress;
        private UtilityTool _utilityTool;

        protected override void PrepareVariables()
        {
            Title = "NetworkMiner";
            Uri = _uriAddress = "https://www.netresec.com/?page=NetworkMiner/";
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