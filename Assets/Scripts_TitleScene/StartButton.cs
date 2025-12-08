using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    void Update()
    {
        
    }

    void StartPressed()
    {
        SceneManager.LoadScene("GameScene");
    }
}
