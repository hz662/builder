using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class PlaceIndicatorFW : MonoBehaviour
{
    private ARRaycastManager raycastManager;
    private GameObject indicator;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public GameObject CoolerOB;
    public GameObject cooler;
    public GameObject pc; 
    public GameObject powersupply;
    public GameObject PowerSupplyOB;
    public GameObject Replay;
    public GameObject Next; 


    void Start()
    {
        Replay.SetActive(false);
        Next.SetActive(false);
        cooler.SetActive(false);
        CoolerOB.SetActive(false);
        pc.SetActive(false);
        powersupply.SetActive(false);
        PowerSupplyOB.SetActive(false); 
        raycastManager = FindObjectOfType<ARRaycastManager>();
        indicator = transform.GetChild(0).gameObject;
        indicator.SetActive(false);

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
