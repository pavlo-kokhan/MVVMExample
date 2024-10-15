using System.Windows;
using System.Windows.Controls;
using Booking.Model;

namespace Booking.UserControls;

public partial class BookingUserControl : UserControl
{
    public static readonly DependencyProperty BookingProperty = DependencyProperty.Register(
        nameof(Booking), 
        typeof(BookingClass), 
        typeof(BookingUserControl), 
        new PropertyMetadata(null));
    
    public BookingClass Booking
    {
        get => (BookingClass)GetValue(BookingProperty);
        set => SetValue(BookingProperty, value);
    }
    
    public BookingUserControl()
    {
        InitializeComponent();
    }
}