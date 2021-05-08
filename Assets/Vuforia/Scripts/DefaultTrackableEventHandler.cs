using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{
    public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
    {
        public Transform TextTargetName;
        public Transform TextDescription;
        public Transform button_panel;
        public AudioSource sfx;
        public Animator obj;
        public Button playBtn;
        public Button stopBtn;

        #region PRIVATE_MEMBER_VARIABLES

        protected TrackableBehaviour mTrackableBehaviour;

        #endregion // PRIVATE_MEMBER_VARIABLES

        #region UNTIY_MONOBEHAVIOUR_METHODS

        protected virtual void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS

        #region PUBLIC_METHODS

        /// <summary>
        ///     Implementation of the ITrackableEventHandler function called when the
        ///     tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
            TrackableBehaviour.Status previousStatus,
            TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
                OnTrackingFound();
            }
            else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                     newStatus == TrackableBehaviour.Status.NOT_FOUND)
            {
                Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
                OnTrackingLost();
            }
            else
            {
                // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
                // Vuforia is starting, but tracking has not been lost or found yet
                // Call OnTrackingLost() to hide the augmentations
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS

        #region PRIVATE_METHODS

        protected virtual void OnTrackingFound()
        {
            var rendererComponents = GetComponentsInChildren<Renderer>(true);
            var colliderComponents = GetComponentsInChildren<Collider>(true);
            var canvasComponents = GetComponentsInChildren<Canvas>(true);

            // Enable rendering:
            foreach (var component in rendererComponents)
                component.enabled = true;

            // Enable colliders:
            foreach (var component in colliderComponents)
                component.enabled = true;

            // Enable canvas':
            foreach (var component in canvasComponents)
                component.enabled = true;
            button_panel.gameObject.SetActive(true);
        }


        protected virtual void OnTrackingLost()
        {
            var rendererComponents = GetComponentsInChildren<Renderer>(true);
            var colliderComponents = GetComponentsInChildren<Collider>(true);
            var canvasComponents = GetComponentsInChildren<Canvas>(true);

            // Disable rendering:
            foreach (var component in rendererComponents)
                component.enabled = false;

            // Disable colliders:
            foreach (var component in colliderComponents)
                component.enabled = false;

            // Disable canvas':
            foreach (var component in canvasComponents)
                component.enabled = false;

            TextTargetName.GetComponent<Text>().text = "???";
            TextDescription.GetComponent<Text>().text = "???";
            button_panel.gameObject.SetActive(false);
            playBtn.gameObject.SetActive(true);
            stopBtn.gameObject.SetActive(false);
            obj.Play("idle");
            sfx.Stop();
;        }

        #endregion // PRIVATE_METHODS
    }
}
