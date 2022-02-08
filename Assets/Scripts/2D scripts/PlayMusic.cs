using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();
    }

    public void Play()
    {
        if (audioSource.isPlaying) return;
        audioSource.Play();
    }

    public void Stop()
    {
        audioSource.Stop();
    }
}
