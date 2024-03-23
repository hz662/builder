using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    public void SwitchScenesToSurface()
    {
    SceneManager.LoadScene("surface");

    }
    public void SwitchScenesToImage()
    {
    SceneManager.LoadScene("Image");

    }

}