using System.Windows;

namespace DiceRoller;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>


public class DiceRoll
{
    public static Random random = new Random();
    public static int D20() => random.Next(1, 21);
    public static int D12() => random.Next(1, 13);
    public static int D8() => random.Next(1, 9);
    public static int D6() => random.Next(1, 7);
    public static int D4() => random.Next(1, 5);
    public static int D100() => random.Next(1, 101);


}

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void OperationButton_Click(object sender, RoutedEventArgs e)
    {

        if (sender == d20Button)
            resultLabel.Content = DiceRoll.D20().ToString();
        if (sender == d12Button)
            resultLabel.Content = DiceRoll.D12().ToString();
        if (sender == d8Button)
            resultLabel.Content = DiceRoll.D8().ToString();
        if (sender == d6Button)
            resultLabel.Content = DiceRoll.D6().ToString();
        if (sender == d4Button)
            resultLabel.Content = DiceRoll.D4().ToString();
        if (sender == d100Button)
            resultLabel.Content = DiceRoll.D100().ToString();
    }
}