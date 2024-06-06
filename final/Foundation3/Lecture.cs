public class Lecture : Event {

    //Personal Attributes:.................

    private string _speaker;
    private int _capacity;

    //Constructor.................

    public Lecture(string title, string description, string date, TimeOnly time, Address address, string type, string speaker, int capacity) : base (title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    //Getter and Setter.................

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    //Methods.................
    public string GetMessage(){

        string fullMsg = $"\n\nSpeaker: {_speaker}\nCapacity: {_capacity}";
        return fullMsg;

    }

}