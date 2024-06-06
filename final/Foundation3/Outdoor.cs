public class Outdoor : Event {

    //Attributes.................

    private string _weather;


    //Constructor.................
    public Outdoor(string title, string description, string date, TimeOnly time, Address address, string type, string weather) : base(title, description, date, time, address, type){
        _weather = weather; 
    }

    //Getter and Setter.................
    public string GetWeather(){
        return _weather;
    }

    public void SetWeather(string weather){
        _weather = weather;
    }

    //Methods.................
    public string GetMessage()
    {
        string msg = $"\n\nThe Statement of the weather is {_weather}";
        return msg;
    }


}