using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using Newtonsoft.Json;

namespace Booking.Model;

public static class ModelSerializer<T> where T : class
{
    public static void SerializeCollection(string filePath, Collection<T> collection)
    {
        var json = JsonConvert.SerializeObject(collection, Formatting.Indented);
        File.WriteAllText(filePath, json, Encoding.UTF8);
    }

    public static Collection<T>? DeserializeCollection(string filePath)
    {
        if (File.Exists(filePath))
        {
            var content = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Collection<T>>(content);
        }

        return null;
    }
}