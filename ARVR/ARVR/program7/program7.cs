using UnityEngine;
using Vuforia;
using UnityEngine.Playables;

public class TruckController : MonoBehaviour
{
    public PlayableDirector timeline;
    public AudioSource truckSound;
    //private ObserverBehaviour observerBehaviour;

    //private void Start()
    //{
    //    observerBehaviour = GetComponent<ObserverBehaviour>();

    //    if (observerBehaviour != null)
    //        observerBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;

    //    if (timeline == null)
    //        timeline = GetComponent<PlayableDirector>();

    //    if (truckSound == null)
    //        truckSound = GetComponent<AudioSource>();
    //}

    //private void OnDestroy()
    //{
    //    if (observerBehaviour != null)
    //        observerBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
    //}

    //private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    //{
    //    if (targetStatus.Status == Status.TRACKED || targetStatus.Status == Status.EXTENDED_TRACKED)
    //    {
    //        timeline.Play();
    //        truckSound.Play();
    //    }
    //    else
    //    {
    //        timeline.Stop();
    //        truckSound.Stop();
    //        timeline.time = 0; // Reset animation
    //        timeline.Evaluate();
    //    }
    //}

    public void Play()
    {
        timeline.Play();
        truckSound.Play();
    }

    public void Stop()
    {
        timeline.Stop();
        truckSound.Stop();
        timeline.time = 0; // Reset animation
        timeline.Evaluate();
    }
}
