using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class sfxManajer : MonoBehaviour
{
    public AudioSource click;
    public AudioSource flip;
    public AudioSource won;

    // Start is called before the first frame update
    public void PlayClick()
    {
        click.Play();
    }

    public void PlayFlip()
    {
        flip.Play();
    }

    public void PlayWon()
    {
        won.Play();
    }
}
