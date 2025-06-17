using UnityEngine;
using UnityEngine.UI;

public class LevelDisplay : MonoBehaviour
{
    public Text textoNivel;

    public void ActualizarNivel(int nivel)
    {
        Debug.Log("ActualizarNivel llamado con nivel: " + nivel);
        textoNivel.text = "Nivel " + nivel.ToString();
    }
}
