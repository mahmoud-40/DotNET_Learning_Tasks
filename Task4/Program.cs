namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();

            eventManager.Add(new EventHandler(HandleEvent));

            Console.WriteLine("Triggering the event...");
            eventManager.Trigger();

            eventManager.Remove(new EventHandler(HandleEvent));

            Console.WriteLine("Triggering the event again...");
            eventManager.Trigger();
        }

        static void HandleEvent()
        {
            Console.WriteLine("Event handled!");
        }
    }
    public delegate void EventHandler();

    public class EventManager
    {
        private event EventHandler eventHandler;

        public void Add(EventHandler handler)
        {
            eventHandler += handler;
        }

        public void Remove(EventHandler handler)
        {
            eventHandler -= handler;
        }

        public void Trigger()
        {
            if (eventHandler != null)
            {
                eventHandler.Invoke();
            }
        }
    }
}