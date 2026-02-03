using AppCommunications;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class StateTeiggerButton : MonoBehaviour
{
    [SerializeField]
    private UIDocument m_UIButton;
    [SerializeField]
    private AppState m_StateToTrigger;
    private Button m_Button;


    public UnityEvent<AppState> TriggerAppstate;

    private void Start()
    {
        m_Button = m_UIButton.rootVisualElement.Query<Button>("trigger-button");
        m_Button.RegisterCallback<ClickEvent>(ev => TriggerAppstate.Invoke(m_StateToTrigger));
    }

    private void OnDestroy()
    {
        m_Button.UnregisterCallback<ClickEvent>(ev => TriggerAppstate.Invoke(m_StateToTrigger));
    }
}
