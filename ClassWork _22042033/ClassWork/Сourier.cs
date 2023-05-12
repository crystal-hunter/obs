
public interface IObserver
{
    void Update(ISubject subject);
}


public class Mail : IObserver
{
    private string name;
    public Mail(string name)
    {
        this.name = name;
    }

    public void Update(ISubject subject)
    {
        if (subject is MailStation)
        {
            Console.WriteLine($" {name}: Пришло новое пишьмо на почтовую станцию. ");
        }
    }
}
