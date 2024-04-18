using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
public class HaroonPlace : MonoBehaviour
{

    private HaroonIndicator HaroonIndicator;
    public GameObject objectToPlace;
    public GameObject placeButton;
    public GameObject ssdButton;
    public GameObject GpuButton;
    public GameObject backbtn;
    public GameObject ssd;
    public GameObject Gpu;
    private bool isRotating = false;
    private Vector2 prevTouchPos;
    private float rotationSpeed = 0.5f;
    void Start()
    {
        HaroonIndicator = FindObjectOfType<HaroonIndicator>();
        ssdButton.SetActive(false);
        GpuButton.SetActive(false);
        backbtn.SetActive(false);
        Gpu.SetActive(false);
        ssd.SetActive(false);

    }

    public void ClickToPlace()
    {

        objectToPlace.SetActive(true);
        Quaternion desiredRotation = Quaternion.Euler(0, 270, -68);
        objectToPlace.transform.position = HaroonIndicator.transform.position;
        HaroonIndicator.gameObject.SetActive(false);
        placeButton.gameObject.SetActive(false);
        ssdButton.SetActive(true);
        GpuButton.SetActive(true);
        backbtn.SetActive(true);
    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject == objectToPlace)
                    {
                        isRotating = true;
                        prevTouchPos = touch.position;
                    }
                }
            }
            else if (touch.phase == TouchPhase.Moved && isRotating)
            {
                float deltaX = touch.position.x - prevTouchPos.x;
                float deltaY = touch.position.y - prevTouchPos.y;
                float rotationX = deltaY * rotationSpeed;
                float rotationY = -deltaX * rotationSpeed;

                objectToPlace.transform.Rotate(Vector3.up, rotationX, Space.World);
                objectToPlace.transform.Rotate(Vector3.right, rotationY, Space.World);

                prevTouchPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                isRotating = false;
            }
        }
    }
}
