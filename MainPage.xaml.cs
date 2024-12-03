using System.Collections.ObjectModel;
using Telerik.Maui.Controls.Data;

namespace CollectionViewFilterIssue
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<MenuItem> MenuItems { get; private set; } = [];
        private MenuItem item1;
        private MenuItem item2;
        private MenuItem item3;
        private MenuItem item4;
        private MenuItem item5;
        private MenuItem item6;
        private MenuItem item7;

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
            this.listView.FilterDescriptors.Add(new BooleanFilterDescriptor { PropertyName = nameof(MenuItem.Visible), Value = true });
            item1 = new MenuItem() { Title = "Item 1", Visible = true };
            item2 = new MenuItem() { Title = "Item 2", Visible = true };
            item3 = new MenuItem() { Title = "Item 3", Visible = true };
            item4 = new MenuItem() { Title = "Item 4", Visible = true };
            item5 = new MenuItem() { Title = "Item 5", Visible = true };
            item6 = new MenuItem() { Title = "Item 6", Visible = true };
            item7 = new MenuItem() { Title = "Item 7", Visible = true };

            MenuItems.Add(item1);
            MenuItems.Add(item2);
            MenuItems.Add(item3);
            MenuItems.Add(item4);
            MenuItems.Add(item5);
            MenuItems.Add(item6);
            MenuItems.Add(item7);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            item5.Visible = false;
            item6.Visible = false;
            item7.Visible = false;
        }

        private void BtnShowItems_Clicked(object sender, EventArgs e)
        {
            item5.Visible = true;
            item6.Visible = true;
            item7.Visible = true;
        }
    }

}
