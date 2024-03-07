using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
public class PlaceIndicator : MonoBehaviour
{
    private ARRaycastManager raycastManager;
    private GameObject indicator;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>(); 
    public GameObject MotherBoard;
    public GameObject rAM;
    public GameObject pc;
    public GameObject cpuToDisable;
    public GameObject cpuTohide;
    public GameObject Rams;
    public GameObject slider;
    public GameObject Replay;
    public GameObject Next;


    void Start()
    {
        Replay.SetActive(false);
        Next.SetActive(false);
        raycastManager = FindObjectOfType<ARRaycastManager>(); 
        indicator = transform.GetChild(0).gameObject; 
        indicator.SetActive(false); 
        rAM.SetActive(false);
        MotherBoard.SetActive(false);
        pc.SetActive(false);
        cpuToDisable.SetActive(false);
        cpuTohide.SetActive(false);
        Rams.SetActive(false);
        slider.SetActive(false);

    }

    void Update()
    {
        var ray = new Vector2(Screen.width / 2, Screen.height / 2); 

        if (raycastManager.Raycast(ray, hits, TrackableType.PlaneWithinPolygon)) 
        {
            Pose hitPose = hits[0].pose; 
            transform.position = hitPose.position;
            transform.rotation = hitPose.rotation;

            if (!indicator.activeInHierarchy)
            {
                indicator.SetActive(true);
            }
        }
    }
}

