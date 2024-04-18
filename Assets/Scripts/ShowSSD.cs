using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class ShowSSD : MonoBehaviour
{
    public GameObject ssdButton;
    public GameObject ssd;

    public void ShowSsd()
    {
        ssd.SetActive(true);
        ssdButton.SetActive(false); 
    }

}
