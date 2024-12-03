using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace CollectionViewFilterIssue
{
    public partial class MenuItem : ObservableObject
    {
        #region Properties
        [ObservableProperty]
        private int index;

        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private bool visible = true;



        #endregion Properties


    }
}
