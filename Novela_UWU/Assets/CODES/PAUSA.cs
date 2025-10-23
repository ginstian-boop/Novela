using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DesactivarFobdo : MonoBehaviour
{
    [SerializeField]
    private GameObject panelMenuPausa;
    private static bool JuegoPausado = false;
    void Start()
    {

        panelMenuPausa.SetActive(false);
        Time.timeScale = 1f;
        JuegoPausado = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            switch (JuegoPausado)
            {
                case true:

                    Reanudar();
                    break;
                case false:

                    Pausar();
                    break;
            }
        }
    }


    public void Reanudar()
    {
        panelMenuPausa.SetActive(false);
        Time.timeScale = 1f;
        JuegoPausado = false;
    }

    private void Pausar()
    {
        panelMenuPausa.SetActive(true);
        Time.timeScale = 0f;
        JuegoPausado = true;
    }


    public void SalirDelJuego()
    {
        Debug.Log("haloo");
        Application.Quit();
           #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
      #endif

    }
}