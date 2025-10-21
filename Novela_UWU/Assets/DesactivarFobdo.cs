using UnityEngine;

public class DesactivarFobdo : MonoBehaviour
{
    public GameObject backGround;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Desactivar()
    {
        backGround.SetActive(false);
    }
}
