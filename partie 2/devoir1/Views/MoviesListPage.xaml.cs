namespace MovieCatalog.Views;

public partial class MoviesListPage : ContentPage
{
	public MoviesListPage()
	{
		InitializeComponent();
	}

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    if (e.CurrentSelection.Count == 0)
        return;

    await Navigation.PushAsync(new Views.MovieDetailPage());

    // Deselect
    ((CollectionView)sender).SelectedItem = null;
}
    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        MenuItem menuItem = (MenuItem)sender;
        ViewModels.MovieViewModel movie = (ViewModels.MovieViewModel)menuItem.BindingContext;
        App.MainViewModel?.DeleteMovie(movie);
    }
}