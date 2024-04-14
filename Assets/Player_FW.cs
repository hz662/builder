using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_FW : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1, sfx2, sfx3;

    public void NewCase()
    {
        src.clip = sfx1;
        src.Play();
    }

    public void Cooler()
    {
        src.clip = sfx2;
        src.Play();
    }

    public void PowerSupply()
    {
        src.clip = sfx3;
        src.Play();
    }

}
