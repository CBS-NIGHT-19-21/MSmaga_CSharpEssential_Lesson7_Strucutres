// Declare structure Notebook.
struct Notebook
{   // Declare fields of the structure Notebook. Initialisation of it is not possible here.
    private readonly string _model;
    private readonly string _manufacture;
    private readonly decimal _price;

    // Declare constructor of the structure Notebook. Initialisation of its fields.
    public Notebook(string model, string manufacture, decimal price)
    {
        _model = model;
        _manufacture = manufacture;
        _price = price;

        Console.WriteLine("Instance the structure and initialization of instance fields.");
    }

    // Declare attributes of the structure Notebook. 
    public string Model { get { return _model; } }
    public string Manufacture { get { return _manufacture; } }
    public decimal Price { get { return _price; } }

    /// <summary>
    /// Shows attributes of the structure instance.
    /// </summary>
    public void Show()
    {
        Console.WriteLine($"Model: {Model}, Manufacture: {Manufacture} Price: ${Price} USD");
    }
}
