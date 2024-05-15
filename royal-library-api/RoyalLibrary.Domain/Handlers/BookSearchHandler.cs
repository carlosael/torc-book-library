namespace RoyalLibrary.Domain.Handlers
{
    public class BookSearchEvent
    {
        public string BookSearch { get; }

        public BookSearchEvent(string bookSearch)
        {
            BookSearch = bookSearch;
        }
    }

    public interface IListener
    {
    }

    public interface IListener<T> : IListener
    {
        void HandleMessage(T message);
    }

    public class BookSearchEventListener : IListener<BookSearchEvent>
    {
        

        public BookSearchEventListener()
        {
            
        }

        public void HandleMessage(BookSearchEvent message)
        {
            Console.WriteLine($"{message.BookSearch}");
        }
    }

    public interface IDispatcher
    {
        void Publish<T>(T message);
    }

    public class Dispatcher : IDispatcher
    {
        private readonly IEnumerable<IListener> _listeners;

        public Dispatcher(IEnumerable<IListener> listeners)
        {
            _listeners = listeners;
        }

        public void Publish<T>(T message)
        {
            foreach (var listener in _listeners.OfType<IListener<T>>())
            {
                listener.HandleMessage(message);
            }
        }
    }
}
