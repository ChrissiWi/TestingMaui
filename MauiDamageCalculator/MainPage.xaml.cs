namespace MauiDamageCalculator;

public partial class MainPage : ContentPage
{
	
	SwordDamage swordDamage = new SwordDamage();
	public MainPage()
	{
		InitializeComponent();
		Flaming.IsChecked = false;
		Magic.IsChecked = false;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		RollDice();
		DisplayDamage();
	}

	private void Magic_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		swordDamage.Magic = e.Value;
		DisplayDamage();
	}

	private void Flaming_CheckedChanged(object sender, CheckedChangedEventArgs e)	
	{
		swordDamage.Flaming = e.Value;
		DisplayDamage();
	}

	private void DisplayDamage()
	{
		Damage.Text = $"Rolled {swordDamage.Roll} for {swordDamage.Damage} damage";
	}

	public void RollDice()
    {
        swordDamage.Roll = Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7);
    }

}

