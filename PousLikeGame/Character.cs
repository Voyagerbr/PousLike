
public class Character
{
	protected string Fotinha; //Foto do Personagem
    protected double Thisrst; //Sede do Personagem
    protected double Hungry; //Fome do Personagem
    protected double Energy; //Energia do Personagem
    protected string Names; // Nome do Personagem
    
    public Character()
    {
        Thisrst = 0;
        Energy = 0;
        Hungry = 0;
    }
    public string GetPhoto() //Para pergar a foto do personagem
    {
        return Fotinha;
    }
    public string GetNames() //Para pegar o nome do Personagem
    {
        return Names;
    }
//===========================================================================================================
    public double GetThisrst() //Para pegar a sede do Personagem
    
    {
        return Thisrst;
    }
    public double GetHungry() //Para pegar a fome do Personagem
    
    {
        return Hungry;
    }
    public double GetEnergy() //Para pegar a Energia do Personagem
    
    {
        return Energy;
    }
//============================================================================================================
    public void SetThisrt (double T)
    {
        if (T < 0)
        Thisrst = 0;

        else if (T > 1)
        Thisrst = 1;

        else
        Thisrst = T;
    }
    public void SetHungry (double H)
    {
        if (H < 0)
        Hungry = 0;

        else if (H > 1)
        Hungry = 1;
        
        else
        Hungry = H;
    }
    public void SetEnergy (double E)
    {
        if (E < 0)
        Energy = 0;

        else if (E > 1)
        Energy = 1;
        
        else
        Energy = E;
    }
//=================================================================================================================
}
