using System.Collections.Generic;
using UnityEngine;

namespace AppCommunications
{
    public class MultiStateSubscriber : StateSubscriber
    {
        [SerializeField]
        private List<AppState> m_StatesToHandle;

        protected override void OnNotifySubscribers(AppState state, PublishedData eventdata)
        {
            switch (state)
            {
                case AppState.LandingScreen:
                    break;
                case AppState.Submenu:
                    break;
                case AppState.Inactive:
                    break;
                case AppState.VideoPlayer:
                    break;
                case AppState.ImageViewer:
                    break;
                case AppState.About:
                    break;
                default:
                    break;
            }
        }
        protected override void HandleState(AppState state, PublishedData data)
        {
            //rise and shine
        }
        protected override void IgnoreState(AppState state, PublishedData data)
        {
           //wrap up and hide
        }
    }
}
