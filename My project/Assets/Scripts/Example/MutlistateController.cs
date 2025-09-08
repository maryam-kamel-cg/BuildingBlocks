using AppCommunications;
using UnityEngine;

public class MutlistateController : MultiStateSubscriber
{
    public override void OnNotifySubscribers(AppState state, PublishedData eventdata)
    {
        // Fix: Use a lambda expression to provide a Predicate<AppState> to the Find method
        if (base.m_StatesToHandle.Contains(state))
        {
            HandleState(state, eventdata);
        }
        else
        {
            IgnoreState(state, eventdata);
        }
    }

    public override void HandleState(AppState state, PublishedData data)
    {
        switch (state)
        {
            case AppState.State1:
                Debug.Log("State1");
                break;
            case AppState.State2:
                Debug.Log("State2");
                break;
            case AppState.Stat3:
                Debug.Log("State3");
                break;
            case AppState.State4:
                Debug.Log("State4");
                break;
            case AppState.State5:
                Debug.Log("State5");
                break;
            case AppState.State6:
                Debug.Log("State6");
                break;
        }
    }

    public override void IgnoreState(AppState state, PublishedData data)
    {
    }
}
