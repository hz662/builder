using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayManager : MonoBehaviour
{

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
