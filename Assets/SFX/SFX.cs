using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip enterSound;
    public AudioClip exitSound;
    public AudioClip hurtSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();  
    }

    public void PlayEnterSound()
    {
        audioSource.PlayOneShot(enterSound);
    }

    public void PlayExitSound()
    {
        audioSource.PlayOneShot(exitSound);
    }

    public void PlayHurtSound()
    {
        audioSource.PlayOneShot(hurtSound);
    }




}
