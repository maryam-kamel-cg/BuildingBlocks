using System;
using UnityEngine;

namespace AppCommunications
{
    public abstract class StateSubscriber : MonoBehaviour
    {
        [SerializeField]
        public AppState m_StateToHandle;
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

        protected virtual void OnNotifySubscribers(AppState state, PublishedData eventdata)
        {
            if (state == m_StateToHandle)
            {
                HandleState(state,eventdata);
            }
            else
            {
                IgnoreState(state, eventdata);
            }
        }

        protected abstract void HandleState(AppState state, PublishedData data);

        protected abstract void IgnoreState(AppState state, PublishedData data);
    }
}
