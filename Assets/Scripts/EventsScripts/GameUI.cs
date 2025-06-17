using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameObject[] elementosUI;

    public void OcultarUI()
    {
        foreach (GameObject ui in elementosUI)
        {
            ui.SetActive(false);
        }
    }

    public void MostrarUI()
    {
        foreach (GameObject ui in elementosUI)
        {
            ui.SetActive(true);
        }
    }
}
