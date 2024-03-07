using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1, sfx2, sfx3, sfx4;

    public void Case()
    {
        src.clip = sfx1;
        src.Play();
    }

    public void MotherBoard()
    {
        src.clip = sfx2;
        src.Play();
    }

    public void CPU()
    {
        src.clip = sfx3;
        src.Play();
    }

    public void RAM()
    {
        src.clip = sfx4;
        src.Play();
    }
}
