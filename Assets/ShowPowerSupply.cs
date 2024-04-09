using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPowerSupply : MonoBehaviour
{
    public Button powersupplyToDisable;
    public GameObject PowerSupply;
    public GameObject PlacepowersupplyB;
    public float timerDuration = 5f;
    public GameObject Replay;
    public GameObject Next;


    public void ClickToPlace()
    {
        PowerSupply.SetActive(true);
        PlacepowersupplyB.SetActive(false);
        StartCoroutine(EnablecpuAfterDelay());


    }

    IEnumerator EnablecpuAfterDelay()
    {
        yield return new WaitForSeconds(timerDuration);

        Replay.SetActive(true);
        Next.SetActive(true);
    }


}
