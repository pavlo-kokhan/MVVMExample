using System.Windows;
using System.Windows.Controls;
using Booking.Model;

namespace Booking.UserControls;

public partial class ClientUserControl : UserControl
{
    public static readonly DependencyProperty ClientProperty = DependencyProperty.Register(
        nameof(Client), 
        typeof(Client), 
        typeof(ClientUserControl), 
        new PropertyMetadata(null));

    
    public Client Client
    {
        get => (Client)GetValue(ClientProperty);
        set => SetValue(ClientProperty, value);
    }
    
    public ClientUserControl()
    {
        InitializeComponent();
    }
}