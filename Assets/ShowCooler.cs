using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCooler : MonoBehaviour
{
    public Button powersupplyToUnDisable;
    public GameObject coolerobject;
    public GameObject coolerB;
    public float timerDuration = 6f;


    public void ClickToPlace()
    {
        coolerobject.SetActive(true);
        coolerB.SetActive(false);
        StartCoroutine(EnablecpuAfterDelay());

    }

    IEnumerator EnablecpuAfterDelay()
    {
        yield return new WaitForSeconds(timerDuration);

        powersupplyToUnDisable.interactable = true;
    }


}
