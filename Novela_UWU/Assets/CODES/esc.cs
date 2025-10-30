using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class esc : MonoBehaviour
{


    void Update()
    { if (Input.GetKeyDown(KeyCode.Escape))
            {
            if (SceneManager.GetActiveScene().buildIndex > 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
            // If it's the first scene, loads itself or the first scene again
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
