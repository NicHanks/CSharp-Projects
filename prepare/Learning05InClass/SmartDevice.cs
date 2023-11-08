using System;

class SmartDevice
{
    bool _isOn = false;
    DateTime _dateTimeOn = new DateTime();
    DateTime _dateTimeOff = new DateTime();


    public SmartDevice()
    {

    }

    public void TurnOn()
    {
        _dateTimeOn = DateTime.Now;
        _isOn = true;
        Console.WriteLine("device is on");
    }
    public void TurnOff()
    {
        _dateTimeOff = DateTime.Now;
        _isOn = false;
        Console.WriteLine("device is off");
    }
    public void GetTime()
    {
        
        TimeSpan timelap = _dateTimeOn-_dateTimeOff;
        Console.WriteLine(timelap);
    }
}
