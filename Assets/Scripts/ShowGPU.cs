using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class ShowGPU : MonoBehaviour
{
    public GameObject GPUbtn;
    public GameObject GPU;

    public void ShowGpU()
    {
        GPU.SetActive(true);
        GPUbtn.SetActive(false);
    }

}

