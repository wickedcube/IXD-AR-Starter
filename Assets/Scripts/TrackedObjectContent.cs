using UnityEngine;
using UnityEngine.Events;
using Vuforia;

namespace IXD.AR
{
    // Put this on a Vuforia target GameObject (Model Target / Object Target).
    // Children are shown while the object is tracked and hidden otherwise.
    [RequireComponent(typeof(ObserverBehaviour))]
    public class TrackedObjectContent : MonoBehaviour
    {
        [SerializeField] bool keepVisibleWhenExtendedTracked = true;

        public UnityEvent onFound;
        public UnityEvent onLost;

        ObserverBehaviour observer;

        void Awake()
        {
            observer = GetComponent<ObserverBehaviour>();
            SetContentVisible(false);
        }

        void OnEnable() => observer.OnTargetStatusChanged += OnStatusChanged;
        void OnDisable() => observer.OnTargetStatusChanged -= OnStatusChanged;

        void OnStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
        {
            bool found = status.Status == Status.TRACKED ||
                         (keepVisibleWhenExtendedTracked && status.Status == Status.EXTENDED_TRACKED);

            SetContentVisible(found);
            (found ? onFound : onLost)?.Invoke();
        }

        void SetContentVisible(bool visible)
        {
            foreach (Transform child in transform)
                child.gameObject.SetActive(visible);
        }
    }
}
