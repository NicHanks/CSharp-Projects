public class Laptop {
    private double _screenSize;
    private string _os;
    private bool _touchscreen;
    private string _cpu;

    public Laptop(double screenSize, string os, bool ts, string CPUUU) //constructor doesn't have to return anything cuz it's building the laptop
    {
        _screenSize = screenSize;
        _os = os;
        _touchscreen = ts;
        _cpu = CPUUU;
    }
    
    public void ShowDetails() 
    {
        Console.WriteLine($"{_screenSize} {_os} {_touchscreen} {_cpu}");
    }

}