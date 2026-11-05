namespace MauiCalculator;

public partial class CalcPage : ContentPage
{
	private int num1;
	private int num2;
    private string operation ="";
    public CalcPage()
	{
		InitializeComponent();
	}
	private void ButtonDigit_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
        if (operation == "")
        {
            num1 = num1 * 10 + int.Parse(button.Text);
        }
        else
        {
            num2 = num2 * 10 + int.Parse(button.Text);
        }



		lblResult.Text += button.Text;
    }
    private void ButtonOperator_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        lblResult.Text += button.Text;
        operation = button.Text;


    }

    private void ButtonClear_Clicked(object sender, EventArgs e)
    {
        lblResult.Text = "";
    }

    private void ButtonEquals_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        lblResult.Text += button.Text;

    }


}