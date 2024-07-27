using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.ElasticSearch.ViewModel;

namespace SecurityStudio.Module.Tool.ElasticSearch.View
{
    public partial class SsElasticSearchView : SsView
    {
        public SsElasticSearchView(SsElasticSearchViewModel ssElasticSearchViewModel)
            : base(ssElasticSearchViewModel)
        {
            InitializeComponent();
        }
    }
}