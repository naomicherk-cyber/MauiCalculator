namespace MauiCalculator;

public partial class CalcPage : ContentPage
{
	public CalcPage()
	{
		InitializeComponent();
	}
	private void ButtonDigit_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		int num=int.Parse(button.Text);

		lblResult.Text = num+"+5="+(num+5);
    }
}