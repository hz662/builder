using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Showrams : MonoBehaviour
{
   public Button ramToDisable;
   public GameObject Rams;
   public GameObject Placerams;
   public float timerDuration = 5f;
   public GameObject Replay;
   public GameObject Next;


   public void ClickToPlace(){
    Rams.SetActive(true);
    Placerams.SetActive(false);
    StartCoroutine(EnablecpuAfterDelay());

   
   }

    IEnumerator EnablecpuAfterDelay()
    {
        yield return new WaitForSeconds(timerDuration);

        Replay.SetActive(true);
        Next.SetActive(true);
    }

   
   }