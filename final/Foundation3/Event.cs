class Event
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

    public string DisplayStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.DisplayAddress()}";
    }

    public string DisplayFullDetails()
    {
        return DisplayStandardDetails();
    }

    public string DisplayShortDescription()
    {
        return $"Type: Event\nTitle: {_title}\nDate: {_date}";
    }
}