using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowCpu : MonoBehaviour
{
   public Button ramToEnable;
   public GameObject CPUunit;
   public GameObject CPUbutton;
   public float timerDuration = 6f;


   public void ClickToPlace(){
    CPUunit.SetActive(true);
    CPUbutton.SetActive(false);
    StartCoroutine(EnableRamAfterDelay());   
   }

    IEnumerator EnableRamAfterDelay()
    {
        yield return new WaitForSeconds(timerDuration);

        ramToEnable.interactable = true;
    }
}