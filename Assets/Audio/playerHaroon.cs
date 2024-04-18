using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHaroon : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1, sfx2 ;


    public void GPU()
    {
        src.clip = sfx1;
        src.Play();
    }

    public void SSD()
    {
        src.clip = sfx2;
        src.Play();
    }
}
