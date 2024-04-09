using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlaceManagerFW : MonoBehaviour
{
    private PlaceIndicatorFW placeIndicator;
    public GameObject objectToPlace;
    public GameObject placeButton;
    public GameObject cooler;
    public GameObject powersupply;
    private GameObject newPlacedObject;
    /*public GameObject motherobject;*/
    public Button coolerToDisable;
    public Button powersupplyToDisable;
    private bool isRotating = false;
    private Vector2 prevTouchPos;
    private float rotationSpeed = 0.5f;
    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicatorFW>();
        /*motherobject.SetActive(false); */
        /*coolerToDisable.interactable = false;*/
        powersupplyToDisable.interactable = false;
    }

    public void ClickToPlace()
    {

        cooler.SetActive(true);
        powersupply.SetActive(true);
        placeButton.gameObject.SetActive(false);
        objectToPlace.SetActive(true);
        Quaternion desiredRotation = Quaternion.Euler(0, 270, -68);
        objectToPlace.transform.position = placeIndicator.transform.position;
        objectToPlace.transform.rotation = desiredRotation;
        placeIndicator.gameObject.SetActive(false);
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
