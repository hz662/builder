using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowMotherboard : MonoBehaviour
{
    public Button cpuToDisable;
   public GameObject motherobject;
   public GameObject PlaceMotherBoard;
   public float timerDuration = 6f;


   public void ClickToPlace(){
    motherobject.SetActive(true);
    PlaceMotherBoard.SetActive(false);
    StartCoroutine(EnablecpuAfterDelay());
   
   }

    IEnumerator EnablecpuAfterDelay()
    {
        yield return new WaitForSeconds(timerDuration);

        cpuToDisable.interactable = true;
    }

   
   }


