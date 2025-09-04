using System;
using System.Collections;
using UnityEngine;

namespace AppCommunications
{
    public class GlobalIdleDetector : MonoBehaviour
    {
        public  Action<float> UserInteractionDetected;
        public  Action StopIdleDetection;

        [SerializeField]
        private StatePublisher m_StatePublisher;

        //Idle duration in seconds
        private float m_IdleDuration;
        private float m_DefaultIdleDuration = 60.0f;
        private Coroutine m_SwitchToInactive;

        private void Awake()
        {
            m_IdleDuration = m_DefaultIdleDuration;
            UserInteractionDetected += OnUserInteractionDetected;
            StopIdleDetection += OnStopIdleTimer;
        }

        private void OnDestroy()
        {
            UserInteractionDetected -= OnUserInteractionDetected;
            StopIdleDetection -= OnStopIdleTimer;
        }

        private void OnUserInteractionDetected(float newduration = 0.0f)
        {
            if (newduration > 0.0f)
            {
                m_IdleDuration = newduration;
            }
            else
            {
                m_IdleDuration = m_DefaultIdleDuration;
            }
            ClearAndRestartIdleCoroutine();
        }

        private void OnStopIdleTimer()
        {
            ClearIdleCouroutine();
        }
        private void ClearIdleCouroutine()
        {
            if (m_SwitchToInactive != null)
            {
                StopCoroutine(m_SwitchToInactive);
                m_SwitchToInactive = null;
            }
        }

        private void ClearAndRestartIdleCoroutine()
        {
            ClearIdleCouroutine();
            m_SwitchToInactive = StartCoroutine(IdleSwitchToInactiveState());
        }

        private IEnumerator IdleSwitchToInactiveState()
        {
            yield return new WaitForSeconds(m_IdleDuration);
            m_StatePublisher.PublishAppState(AppState.Inactive, new PublishedData());
        }
    }
}
