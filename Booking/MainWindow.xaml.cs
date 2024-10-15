using System.Windows;
using Booking.ViewModels;

namespace Booking;

public partial class MainWindow : Window
{   
    MainWindowViewModel _viewModel;
    
    public MainWindow()
    {
        InitializeComponent();
        _viewModel = new MainWindowViewModel();
        DataContext = _viewModel;
        
        _viewModel.GetBookingsCommand.Execute(null);
        _viewModel.GetClientsCommand.Execute(null);
    }
}