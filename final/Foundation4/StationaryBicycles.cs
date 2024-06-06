public class StationaryBicycles : Activity
{
    //Custom Attributes.................

    private string _bikeNumber;

    public StationaryBicycles(string bikeNum, string date, float len, float distance) : base(date, len, distance)
    {
        _bikeNumber = bikeNum;
        _pace = CalPace();
        _speed = CalSpeed();

    }

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
        return $"{_date} Bicycle No. {_bikeNumber}: ({_length} min)-Distance {_distance:2F} km, Speed: {_speed} kph, Pace: {_pace} min per km";
    }





}