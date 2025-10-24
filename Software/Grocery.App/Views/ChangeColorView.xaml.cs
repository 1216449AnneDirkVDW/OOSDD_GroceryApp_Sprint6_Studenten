using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class ChangeColorView : ContentPage
{
    public ChangeColorView(ChangeColorViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}