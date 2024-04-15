using UnityEngine;
using UnityEngine.SceneManagement;
public class ReplayFW : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
