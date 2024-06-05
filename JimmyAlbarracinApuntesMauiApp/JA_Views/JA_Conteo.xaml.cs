namespace JimmyAlbarracinApuntesMauiApp.JA_Views;

public partial class JA_Conteo : ContentPage
{
	public JA_Conteo()
	{
		InitializeComponent();
	}
    private void OnCalculateButtonClicked(object sender, EventArgs e)
    {
        string input = InputEntry.Text;

        if (string.IsNullOrEmpty(input))
        {
            DisplayAlert("Error", "Ingrese una cadena de caracteres.", "OK");
            return;
        }

        int total = input.Length;
        int numbers = 0;
        int letters = 0;
        int vowels = 0;
        int uppercase = 0;
        int lowercase = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                numbers++;
            }
            else if (char.IsLetter(c))
            {
                letters++;
                if ("aeiouAEIOU".Contains(c))
                {
                    vowels++;
                }
                if (char.IsUpper(c))
                {
                    uppercase++;
                }
                if (char.IsLower(c))
                {
                    lowercase++;
                }
            }
        }

        TotalLabel.Text = $"Total: {total}";
        NumbersLabel.Text = $"Números: {numbers}";
        LettersLabel.Text = $"Letras: {letters}";
        VowelsLabel.Text = $"Vocales: {vowels}";
        UppercaseLabel.Text = $"Mayúsculas: {uppercase}";
        LowercaseLabel.Text = $"Minúsculas: {lowercase}";
    }

    private void OnClearButtonClicked(object sender, EventArgs e)
    {
        InputEntry.Text = string.Empty;
        TotalLabel.Text = string.Empty;
        NumbersLabel.Text = string.Empty;
        LettersLabel.Text = string.Empty;
        VowelsLabel.Text = string.Empty;
        UppercaseLabel.Text = string.Empty;
        LowercaseLabel.Text = string.Empty;
    }
}
