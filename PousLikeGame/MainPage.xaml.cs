namespace PousLikeGame;
public partial class MainPage : ContentPage

{	
  Character Atual;
  Arthur thui;
//=========================================================

	public MainPage()
	{
		InitializeComponent();

		thui = new Arthur();

		Atual = thui;

		CharacterImg.Source = Atual.GetPhoto();
	
	}
	
}

