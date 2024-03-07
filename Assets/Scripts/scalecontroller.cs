using UnityEngine;
using UnityEngine.UI;

public class ScaleController : MonoBehaviour
{
    public Slider slider;
    public GameObject objectToScale;
    public float minScale = 0.15f;
    public float maxScale = 2f;

    void Start()
    {
        UpdateScale();
    }

    void Update()
    {
        UpdateScale();
    }

    void UpdateScale()
    {
        float scaleFactor = Mathf.Lerp(minScale, maxScale, slider.value);

        objectToScale.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
    }
}
