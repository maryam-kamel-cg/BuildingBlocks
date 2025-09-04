using AppCommunications;
using UnityEngine;

public class MutlistateController : MultiStateSubscriber
{
    public override void OnNotifySubscribers(AppState state, PublishedData eventdata)
    {
        switch (state)
        {
            case AppState.LandingScreen:
                Debug.Log("State1");
                break;
            case AppState.Submenu:
                Debug.Log("State2");
                break;
            case AppState.Inactive:
                Debug.Log("State3");
                break;
            case AppState.VideoPlayer:
                Debug.Log("State4");
                break;
            case AppState.ImageViewer:
                Debug.Log("State5");
                break;
            case AppState.About:
                Debug.Log("State6");
                break;
        }
    }
}
