using AppCommunications;

namespace AppCommunications
{
    public interface IStateSubscriber
    {
        public  void OnNotifySubscribers(AppState state, PublishedData eventdata);
        public  void HandleState(AppState state, PublishedData data);
        public  void IgnoreState(AppState state, PublishedData data);
    }
}
