namespace AppCommunications
{
    /// <summary>
    /// the contract of writing subscribers
    ///it was a better way than a single state subscriber,
    ///then expand it multi states subscriber and deal with the confution of other fields & custom inspector
    /// </summary>
    public interface IStateSubscriber
    {
        public  void OnNotifySubscribers(AppState state, PublishedData eventdata);
        public  void HandleState(AppState state, PublishedData data);
        public  void IgnoreState(AppState state, PublishedData data);
    }
}
