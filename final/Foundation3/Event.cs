public class Event {
    //Base Class.................

    protected string _title;
    protected string _description;
    protected string _date;
    protected TimeOnly _time;
    protected Address _address;
    protected string _type;

    //Constructor.................
    public Event(string title, string description, string date, TimeOnly time, Address address, string type) 
    {
        _title = title;
        _description = description;
        _date =  date;
        _time = time;
        _address = address;
        _type = type;
    }

    //Getters and setters <default>.................

    public string GetTitle(){
        return _title;
    }

    public string GetDescription(){
        return _description;
    }

    public string GetDate(){
        return _date;
    }

    public TimeOnly GetTime(){
        return _time;
    }

    public Address GetAdress() {
        return _address;
    }

    public string GetTypeEvent(){
        return _type;
    }

    public void SetTitle(string title) {
        _title = title;
    }

    public void SetDescription(string description){
        _description = description;
    }

    public void SetDate(string date){
        _date = date;
    }

    public void SetTime(TimeOnly time){
        _time = time;
    }

    public void SetAddress(Address address){
        _address = address;
    }

    public void SetTypeEvent(string type){
        _type = type;
    }


    //Methods Messages.................

    public string StandarDetails(){
        string message = $"Event {_title}, \n\nDescription: {_description}\n\nDate: {_date}\nTime: {_time}\n\nAddres: {_address.GetFullAddress()}";
        return message;
    }

    public virtual string FullDetails(string msg){
        //This Method will return a message with full details.................

        string  fullMsg = msg + " " + StandarDetails();

        return fullMsg;
    }

    public string ShortDescription(){
        //This method will return a short message of the event;.................
        string msg = $"type: {_type}\nTitle: {_title}\nDate: {_date}";
        return msg;
    }



}