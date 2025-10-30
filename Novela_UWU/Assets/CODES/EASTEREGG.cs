using UnityEngine;
using UnityEngine.SceneManagement;

public class EASTEREGG : MonoBehaviour
{
    public string codigoSecreto = "KONAMI";
    private string inputActual = "";

    void Update()
    {

        if (Input.anyKeyDown)
        {
            string tecla = Input.inputString;

            if (tecla.Length > 0)
            {
                inputActual += tecla;

                if (inputActual.Length > codigoSecreto.Length)
                {
                    inputActual = inputActual.Substring(1);
                }

                if (inputActual == codigoSecreto)
                {
                    SceneManager.LoadScene("Easteregg");
                    inputActual = "";
                }
            }
        }
    }

}

