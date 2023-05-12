using System;

class Program
{
    static void Main(string[] args)
    {

        var courier1 = new Mail("Почтальён 1");
        var courier2 = new Mail("Почтместер ");
        var station = new MailStation();
        station.add(courier1); 
        station.add(courier2);
        station.addmail();  
        station.remove(courier2); 
        station.addmail();

    }
}
