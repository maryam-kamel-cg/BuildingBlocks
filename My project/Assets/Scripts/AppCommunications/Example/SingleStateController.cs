using AppCommunications;
using UnityEngine;

public class SingleStateController : SingleStateSubscriber
{
    public override void HandleState(AppState state, PublishedData data)
    {
        Debug.Log("This is the state i've been waiting for");
    }

    public override void IgnoreState(AppState state, PublishedData data)
    {
        Debug.Log("Not me");
    }
}
