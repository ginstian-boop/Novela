     using Fungus;
        using UnityEngine;

public class TN : MonoBehaviour
{
    [SerializeField]
    private GameObject tn;     

    void Start()
    {
       
        tn.SetActive(false);
    }

    // Method to activate panel
    public void ShowPanel()
    {
        tn.SetActive(true);
    }

    // Method to deactivate panel
    public void HidePanel()
    {
        tn.SetActive(false);
    }
}
    
    