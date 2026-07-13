public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\n" +
               $"Description: {_description}\n" +
               $"Date: {_date}\n" +
               $"Time: {_time}\n" +
               $"Address:\n{_address.GetAddress()}";
    }

    public string GetShortDescription(string eventType)
    {
        return $"Event Type: {eventType}\n" +
               $"Title: {_title}\n" +
               $"Date: {_date}";
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public Address GetAddress()
    {
        return _address;
    }
}