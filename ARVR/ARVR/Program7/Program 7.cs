using UnityEngine;
using Vuforia;

public class PlayAudioOnDetect : MonoBehaviour
{
    public GameObject truckModel; // 3D Truck Model
    public AudioSource audioSource; // Audio Source for sound

    private ObserverBehaviour observerBehaviour;

    void Start()
    {
        // Get ObserverBehaviour from Image Target
        observerBehaviour = GetComponent<ObserverBehaviour>();
        
        if (observerBehaviour)
        {
            // Register event for marker detection
            observerBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }

        // Initially hide the truck
        truckModel.SetActive(false);
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED)
        {
            // Show truck and play audio when marker is detected
            truckModel.SetActive(true);
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else if (targetStatus.Status == Status.NO_POSE)
        {
            // Hide truck and stop audio when marker is lost
            truckModel.SetActive(false);
            audioSource.Stop();
        }
    }
}
