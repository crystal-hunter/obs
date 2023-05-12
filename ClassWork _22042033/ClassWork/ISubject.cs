public interface ISubject
{
    void add(IObserver observer); //  используется для добавления нового наблюдателя в список
    void remove(IObserver observer); // используется для удаления наблюдателя из списка
    void Notify(); //  сообщает всем об изменении состояния
}
