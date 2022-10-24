using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static SoundManagerScript instance {get;private set;}
    private AudioSource source;

    void Start(){
        instance = this;
        

        source = GetComponent<AudioSource> ();
    }

    void Update(){

    }

    public void PlaySound(AudioClip _sound)
    {
        source.PlayOneShot(_sound);
    }

}
