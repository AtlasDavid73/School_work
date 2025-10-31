namespace CSVDemo;

public class EventRepository
{
    private const string FileName = "events.csv";

    public Event[] ReadEventsFromFile()
    {
        if (!File.Exists(FileName))
        {
            return new Event[0];
        }

        string[] lines = File.ReadAllLines(FileName);
        Event[] events = new Event[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');

            Event e = new Event
            {
                EventDate = DateOnly.Parse(parts[0]),
                Time = TimeOnly.Parse(parts[1]),
                Title = parts[2],
                Description = parts[3]
            };
            events[i] = e;
        }
        return events;
    }

    public void WriteEventToFile(Event e)
    {
        string eventLine = ConvertEventToCsv(e);
        File.AppendAllText(FileName, eventLine + Environment.NewLine);
    }

    private string ConvertEventToCsv(Event e)
    {
        return $"{e.EventDate},{e.Time},{e.Title},{e.Description}";
    }
}