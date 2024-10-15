using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using Booking.DetailsWindows;
using Booking.Model;
using Newtonsoft.Json;

namespace Booking.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<BookingClass> Bookings { get; set; }
    public ObservableCollection<Client> Clients { get; set; }
    
    public RelayCommand GetBookingsCommand => new RelayCommand(execute => GetBookings());
    public RelayCommand AddBookingCommand => new RelayCommand(execute => AddBooking());
    public RelayCommand DeleteBookingCommand => new RelayCommand(execute => DeleteBooking());
    public RelayCommand UpdateBookingCommand => new RelayCommand(execute => UpdateBooking());
    
    public RelayCommand GetClientsCommand => new RelayCommand(execute => GetClients());
    public RelayCommand AddClientCommand => new RelayCommand(execute => AddClient());
    public RelayCommand DeleteClientCommand => new RelayCommand(execute => DeleteClient());
    public RelayCommand UpdateClientCommand => new RelayCommand(execute => UpdateClient());

    public BookingClass SelectedBooking
    {
        get => _selectedBooking;
        set
        {
            _selectedBooking = value;
            OnPropertyChanged();
        }
    }
    
    public Client SelectedClient 
    { 
        get => _selectedClient;
        set
        {
            _selectedClient = value;
            OnPropertyChanged(); 
        }
    }
    
    private BookingClass _selectedBooking;
    private Client _selectedClient;
    private const string BookingsFilePath = "bookings.json";
    private const string ClientsFilePath = "clients.json";

    public MainWindowViewModel()
    {
        Bookings = new ObservableCollection<BookingClass>();
        Clients = new ObservableCollection<Client>();
    }
    
    private void GetBookings()
    {
        if (File.Exists(BookingsFilePath))
        {
            var content = File.ReadAllText(BookingsFilePath);
            var bookings = JsonConvert.DeserializeObject<ObservableCollection<BookingClass>>(content);
            
            Bookings.Clear();
            
            foreach (var booking in bookings)
            {
                Bookings.Add(booking);
            }   
        }
        else
        {
            MessageBox.Show(
                "There is no saved bookings file.", 
                "Error", 
                MessageBoxButton.OK, 
                MessageBoxImage.Error);
        }
    }

    private void AddBooking()
    {
        var detailsWindow = new BookingDetailsWindow 
        { 
            Booking = new BookingClass()
            {
                BookingId = Bookings.Any() ? Bookings.Max(b => b.BookingId) + 1 : 1
            } 
        };
        
        if (detailsWindow.ShowDialog() == true)
        {
            Bookings.Add(detailsWindow.Booking);
            SaveBookings();
        }
    }

    private void DeleteBooking()
    {
        if (SelectedBooking != null)
        {
            Bookings.Remove(SelectedBooking);
            SaveBookings();
        }
    }

    private void UpdateBooking()
    {
        if (SelectedBooking != null)
        {
            var detailsWindow = new BookingDetailsWindow() { Booking = SelectedBooking };
            
            if (detailsWindow.ShowDialog() == true)
            {
                SaveBookings();
            }
        }
    }

    private void SaveBookings()
    {
        var json = JsonConvert.SerializeObject(Bookings, (Newtonsoft.Json.Formatting)Formatting.Indented);
        File.WriteAllText(BookingsFilePath, json, Encoding.UTF8);
    }
    
    private void GetClients()
    {
        if (File.Exists(ClientsFilePath))
        {
            var content = File.ReadAllText(ClientsFilePath);
            var clients = JsonConvert.DeserializeObject<ObservableCollection<Client>>(content);
            
            Clients.Clear();
            
            foreach (var client in clients)
            {
                Clients.Add(client);
            }   
        }
        else
        {
            MessageBox.Show(
                "There is no saved clients file.", 
                "Error", 
                MessageBoxButton.OK, 
                MessageBoxImage.Error);
        }
    }

    private void AddClient()
    {
        var detailsWindow = new ClientDetailsWindow 
        { 
            Client = new Client
            {
                ClientId = Clients.Any() ? Clients.Max(c => c.ClientId) + 1 : 1
            } 
        };
        
        if (detailsWindow.ShowDialog() == true)
        {
            Clients.Add(detailsWindow.Client);
            SaveClients();
        }
    }

    private void DeleteClient()
    {
        if (SelectedClient != null)
        {
            Clients.Remove(SelectedClient);
            SaveClients();
        }
    }

    private void UpdateClient()
    {
        if (SelectedClient != null)
        {
            var detailsWindow = new ClientDetailsWindow { Client = SelectedClient };
            
            if (detailsWindow.ShowDialog() == true)
            {
                SaveClients();
            }
        }
    }

    private void SaveClients()
    {
        var json = JsonConvert.SerializeObject(Clients, (Newtonsoft.Json.Formatting)Formatting.Indented);
        File.WriteAllText(ClientsFilePath, json, Encoding.UTF8);
    }
}