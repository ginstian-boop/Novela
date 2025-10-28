using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class esc : MonoBehaviour
{
   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

    }
}
