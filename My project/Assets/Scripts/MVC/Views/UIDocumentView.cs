using UnityEngine;
using UnityEngine.UIElements;

namespace  MVC.View
{
    public abstract class UIDocumentView : MonoBehaviour
    {
        [SerializeField]
        public UIDocument m_Screen1UIDocument;

        //override as necessary
        protected virtual void Awake()
        {
            RegisterViewItems();
        }
        protected virtual void OnDestroy()
        {
            UnregisterViewItems();
        }

        //must be overriden per view
        protected abstract void UnregisterViewItems();
        protected abstract void RegisterViewItems();

        //keeping them virtual
        public virtual void SetViewVisibility(bool visible)
        {
            if (m_Screen1UIDocument != null)
                m_Screen1UIDocument.rootVisualElement.style.display = visible ? DisplayStyle.Flex : DisplayStyle.None;
        }
        public virtual void DisplayViewData()
        { }
    }
}
