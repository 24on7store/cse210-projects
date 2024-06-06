public class Running : Activity 
{
    //Attributes:.................
    private string _camp;
    
    //Constructor.................
    public Running(string camp, string date, float len, double distance) : base (date, len, distance)
    {
        _camp = camp;
        _pace = CalPace();
        _speed = CalSpeed();
    }

    //Methods.................

    public override double CalPace()
    {
        return _length / _distance;
    }

    public override double CalSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override string GetSummary()
    {
        return $"{_date} Running {_camp}: ({_length} min)-Distance {_distance:3F} km, Speed: {_speed} kph, Pace: {_pace} min per km";
    }



}