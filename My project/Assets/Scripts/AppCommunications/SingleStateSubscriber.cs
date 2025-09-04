using UnityEngine;

namespace AppCommunications
{
    public abstract class SingleStateSubscriber :MonoBehaviour, IStateSubscriber
    {
        [Tooltip("The state to be handled by this subscriber")]
        [SerializeField]
        public AppState m_StateToHandle;

        [Tooltip("The pusblisher broadcast the states and data")]
        [SerializeField]
        public StatePublisher m_StatePublisher;

        protected virtual void Awake()
        {
            m_StatePublisher.NotifySubscribers += OnNotifySubscribers;
        }

        protected virtual void OnDestroy()
        {
            m_StatePublisher.NotifySubscribers -= OnNotifySubscribers;
        }

        public abstract void HandleState(AppState state, PublishedData data);

        public abstract void IgnoreState(AppState state, PublishedData data);

        public virtual void OnNotifySubscribers(AppState state, PublishedData eventdata)
        {
            if (state == m_StateToHandle)
            {
                HandleState(state, eventdata);
            }
            else
            {
                IgnoreState(state, eventdata);
            }
        }
    }
}
