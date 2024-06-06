public class Receptions : Event {

    //Attributes:.................
    private bool _rsvp;
    private string _email;
    
    //Constructor:.................
    public Receptions(string email, string title, string description, string date, TimeOnly time, Address address, string type, bool rsvp) : base (title, description, date, time, address, type)
    {
        _rsvp = rsvp;
        _email = email;
    }

    //Getter and Setter.................
    public bool GetRSVP(){
        return _rsvp;
    }

    public void SetRSVP(bool rsvp){
        _rsvp = rsvp;
    }

    public string GetEmail(){
        return _email;
    }

    public void SetEmail(string email){
        _email = email;
    }

    //Methods:.................
    public string GetMessage(){

        string fullMsg = $"\n\nEmail: {_email}\nCapacity: {GetRSVP_String()}";
        return fullMsg;
    }

    public string GetRSVP_String() {
        //This measure will get the response of the customer.................
        string response;
        if (_rsvp)
        {
            response = "Accepted";
        }
        else
        {
            response = "Denied";
        }
        return response;
    }



}