using System;
using UnityEngine;

namespace AppCommunications
{
    public class StatePublisher : MonoBehaviour
    {
        public Action<AppState, PublishedData> NotifySubscribers;

        [SerializeField]
        private AppState m_CurrentState;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            m_CurrentState = AppState.LandingScreen;
            PublishAppState(AppState.LandingScreen, new PublishedData());
        }

        public void PublishAppState(AppState state, PublishedData headers)
        {
            NotifySubscribers?.Invoke(state, headers);
        }
    }
}
