using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject panelDialogo;
    public Text textoDialogo;

    private bool dialogoActivo = false;

    private void Start()
    {
        panelDialogo.SetActive(false);
    }

    public void MostrarDialogo()
    {
        dialogoActivo = !dialogoActivo;

        if (dialogoActivo)
        {
            textoDialogo.text = "¡Hola! Soy un NPC.";
            panelDialogo.SetActive(true);
        }
        else
        {
            panelDialogo.SetActive(false);
        }
    }
}
