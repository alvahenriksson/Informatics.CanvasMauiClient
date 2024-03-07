using Informatics.CanvasMauiClient.ViewModels; 

namespace Informatics.CanvasMauiClient.Pages;
public partial class CoursesPage : ContentPage
{
public CoursesPage(CoursesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
	}
     protected override void OnAppearing()
     {
        base.OnAppearing();
		var viewModel = (CoursesViewModel)BindingContext;
		viewModel.RefreshCommand.Execute(null); 
	}
}