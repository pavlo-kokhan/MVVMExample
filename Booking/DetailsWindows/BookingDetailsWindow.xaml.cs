using System.Windows;
using Booking.Model;

namespace Booking.DetailsWindows;

public partial class BookingDetailsWindow : Window
{
    public static readonly DependencyProperty BookingProperty = DependencyProperty.Register(
        nameof(Booking), 
        typeof(BookingClass), 
        typeof(BookingDetailsWindow), 
        new PropertyMetadata(null));
    
    public BookingClass Booking
    {
        get => (BookingClass)GetValue(BookingProperty);
        set => SetValue(BookingProperty, value);
    }
    
    public BookingDetailsWindow()
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