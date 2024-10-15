using System.Windows;
using Booking.Model;

namespace Booking.DetailsWindows;

public partial class ClientDetailsWindow : Window
{
    public static readonly DependencyProperty ClientProperty = DependencyProperty.Register(
        nameof(Client), 
        typeof(Client), 
        typeof(ClientDetailsWindow), 
        new PropertyMetadata(null));
    
    public Client Client
    {
        get => (Client)GetValue(ClientProperty);
        set => SetValue(ClientProperty, value);
    }
    
    public ClientDetailsWindow()
    {
        InitializeComponent();
        DataContext = this;
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
        Close();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }
}