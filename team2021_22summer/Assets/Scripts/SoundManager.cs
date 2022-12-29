using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //select
    public AudioSource selectSource;
    public AudioClip selectAudio;
    //back
    public AudioSource backSource;
    public AudioClip backAudio;
    //start
    public AudioSource startSource;
    public AudioClip startAudio;
    //end
    public AudioSource endSource;
    public AudioClip endAudio;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SelectSound()
    {
        selectSource.GetComponent<AudioSource>().PlayOneShot(selectAudio);
    }

    public void BackSound()
    {
        backSource.GetComponent<AudioSource>().PlayOneShot(backAudio);
    }

    public void StartSound()
    {
        startSource.GetComponent<AudioSource>().PlayOneShot(startAudio);
    }

    public void EndSound()
    {
        endSource.GetComponent<AudioSource>().PlayOneShot(endAudio);
    }
}
