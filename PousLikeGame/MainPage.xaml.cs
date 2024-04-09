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
//=====================================================================
		var timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(3);
		timer.Tick += (s, e) => TimePassed();
		timer.Start();
//=====================================================================

		thui = new Arthur();

		dogus = new Dog();

		pensador = new Squirtle();

//======================================================================
		Atual = thui;

//======================================================================

		CharacterImg.Source = Atual.GetPhoto();

		CharacterName.Text = Atual.GetNames();
//======================================================================	
}	
void TimePassed()
	{
		Atual.SetHungry(Atual.GetHungry() - 0.01);
		HungryBar.Progress = Atual.GetHungry();

		Atual.SetThisrt(Atual.GetThisrst() - 0.01);
		ThisrstBar.Progress = Atual.GetThisrst();

		Atual.SetEnergy(Atual.GetEnergy() - 0.01);
		EnergyBar.Progress = Atual.GetEnergy();

		thui.SetHungry(thui.GetHungry() - 0.03);
		thui.SetThisrt(thui.GetThisrst() - 0.04);
		thui.SetEnergy(thui.GetEnergy() - 0.02);

		pensador.SetHungry(pensador.GetHungry() - 0.03);
		pensador.SetThisrt(pensador.GetThisrst() - 0.04);
		pensador.SetEnergy(pensador.GetEnergy() - 0.02);

		dogus.SetHungry(dogus.GetHungry() - 0.03);
		dogus.SetThisrt(dogus.GetThisrst() - 0.04);
		dogus.SetEnergy(dogus.GetEnergy() - 0.02);
		
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
		CharacterName.Text = Atual.GetNames();

	}
	
	private void EnergyButtonIsClicked(object sender, EventArgs args) 
	{
		Atual.SetEnergy(Atual.GetEnergy() + 0.07);
		EnergyBar.Progress = Atual.GetEnergy();
	}
	private void FoodButtonIsClicked(object sender, EventArgs args) 
	{
		Atual.SetHungry(Atual.GetHungry() + 0.07);
		HungryBar.Progress = Atual.GetHungry();
	}
	private void WaterButtonIsClicked(object sender, EventArgs args) 
	{
		Atual.SetThisrt(Atual.GetThisrst() + 0.07);
		ThisrstBar.Progress = Atual.GetThisrst();
	}
}

