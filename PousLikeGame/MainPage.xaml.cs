namespace PousLikeGame;
public partial class MainPage : ContentPage

{	
  Character Atual;
  Arthur thui;
  Squirtle pensador;
  Dog dogus;


//=========================================================

	public MainPage()
	{
		InitializeComponent();

		thui = new Arthur();

		dogus = new Dog();

		pensador = new Squirtle();

		
		Atual = thui;
		CharacterImg.Source = Atual.GetPhoto();

	}
	void ArrowButtonIsClicked(object sender,EventArgs args) 
	{
		

		if (Atual == thui)
		 Atual = dogus;
		
		else if (Atual == dogus)
		Atual = pensador;
		
		else if(Atual == pensador)
		Atual = thui;		
		
		CharacterImg.Source = Atual.GetPhoto();
	}
	
}

