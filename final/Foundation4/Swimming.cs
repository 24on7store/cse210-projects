public class Swimming : Activity {

    //Attribute.................
        //Constructor.................
    public Swimming(string date, float len, int laps) : base (date, len, laps)
    {
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


    public override double CalDistance()
    {
        _distance = _laps * 50 * 1000;
        return _distance;
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming: ({_length} min)-Distance {_distance:2F} km, Speed: {_speed} kph, Pace: {_pace} min per km";
    }


}