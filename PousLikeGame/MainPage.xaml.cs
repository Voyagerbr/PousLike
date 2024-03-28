namespace PousLikeGame;

public partial class MainPage : ContentPage
List<Character> personagem = new List<Character>();
Character CurrentCharacter;
{
	public MainPage()
	{
		InitializeComponent();
		personagem.Add(new Character()
		{
			Hungry = 50,
			Thirst = 50,
			Energy = 50
		});
	
	}
}

