using System;
using System.Collections.Generic;
using UnityEngine;

namespace AppCommunications
{
    [Serializable]
    public abstract class MultiStateSubscriber : MonoBehaviour,IStateSubscriber
    {
        [Tooltip("The pusblisher broadcast the states and data")]
        [SerializeField]
        protected StatePublisher m_StatePublisher;

        [Tooltip("The states to be handled by this subscriber")]
        [SerializeField]
        protected List<AppState> m_StatesToHandle;

        protected virtual void Awake()
        {
            m_StatePublisher.NotifySubscribers += OnNotifySubscribers;
        }

        protected virtual void OnDestroy()
        {
            m_StatePublisher.NotifySubscribers -= OnNotifySubscribers;
        }
        public abstract void OnNotifySubscribers(AppState state, PublishedData eventdata);
        public abstract void HandleState(AppState state, PublishedData data);
        public abstract void IgnoreState(AppState state, PublishedData data);
    }
}
