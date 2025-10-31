using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSVDemo;

public class App
{
    private EventRepository _repository;

    public App()
    {
        _repository = new EventRepository();
    }

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            int choice = ConsoleIO.DisplayMenu();

            switch (choice)
            {
                case 1:
                    ViewAllEvents();
                    break;
                case 2:
                    AddEvent();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            ConsoleIO.AnyKey();
            Console.WriteLine();
        }
    }

    private void ViewAllEvents()
    {
        Console.WriteLine("All Events:");

        Event[] events = _repository.ReadEventsFromFile();

        if (events.Length == 0)
        {
            Console.WriteLine("No events found.");
        }
        else
        {
            foreach (Event e in events)
            {
                ConsoleIO.DisplayEvent(e);
            }
        }
    }

    private void AddEvent()
    {
        Event newEvent = ConsoleIO.CreateEvent();
        _repository.WriteEventToFile(newEvent);
        Console.WriteLine("Event added successfully.");
    }
}
