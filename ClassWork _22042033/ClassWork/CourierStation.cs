using System.Xml.Linq;

public class MailStation : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(this);
        }
    }
    public void addmail()
    {
        Console.WriteLine($"  Почта: Пришло письмо!"); ;
        Notify();
    }
    public void add(IObserver observer)
    {
        observers.Add(observer);
    }

    public void remove(IObserver observer)
    {
        observers.Remove(observer);
    }




}
