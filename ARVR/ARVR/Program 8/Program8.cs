using UnityEngine;

public class Prog3 : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;

    void Start()
    {
        animator = GetComponent<Animator>();     // Grab the Animator on the same GameObject
        audioSource = GetComponent<AudioSource>(); // Grab the AudioSource on the same GameObject
    }

    public void Run()
    {
        animator.SetTrigger("run");  // This triggers the "run" parameter in the Animator
        audioSource.Play();          // This plays the assigned audio clip
    }
}
