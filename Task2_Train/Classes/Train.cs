// Declare structure Train.
struct Train
{   // Declare fields of the structure Train.
    private readonly string _destination;
    private long _number;
    private readonly DateTime _departureTime;

    // Declare attributes of the structure Train.
    public string Destination { get { return _destination; } }
    public long Number { get { return _number; } set { _number = value; } }
    public DateTime DepartureTime { get { return _departureTime; } }

    // Declare constructor of the structure instance and initialization of its fields.
    public Train(string destination, long number, string departureTime)
    {
        _destination = destination;
        _number = number;
        _departureTime = Convert.ToDateTime(departureTime);
    }


}
