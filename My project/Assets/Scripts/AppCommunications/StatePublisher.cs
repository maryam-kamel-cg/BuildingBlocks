using System;
using UnityEngine;

namespace AppCommunications
{
    /// <summary>
    /// This class responsible for publishing app states,
    /// add as a gameobject in the scene and assign it to subscribers
    /// </summary>
    public sealed class StatePublisher : MonoBehaviour
    {
        public Action<AppState, PublishedData> NotifySubscribers;

        [SerializeField]
        private AppState m_CurrentState;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            m_CurrentState = AppState.State1;
            PublishAppState(AppState.State1, new PublishedData());
        }

        public void PublishAppState(AppState state, PublishedData headers)
        {
            NotifySubscribers?.Invoke(state, headers);
        }

        [ContextMenu("PublishCurrentState")]
        private void publishCurrentState()
        { 
            PublishAppState(m_CurrentState, new PublishedData());
        }
    }
}
