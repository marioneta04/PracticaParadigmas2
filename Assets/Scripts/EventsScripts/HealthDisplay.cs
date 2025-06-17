using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Text textoSalud;

    private void OnEnable()
    {
        if (playerHealth != null)
        {
            playerHealth.OnSaludCambio.AddListener(ActualizarTexto);
        }
    }

    private void OnDisable()
    {
        if (playerHealth != null)
        {
            playerHealth.OnSaludCambio.RemoveListener(ActualizarTexto);
        }
    }

    public void ActualizarTexto(int nuevaSalud)
    {
        textoSalud.text = "Salud: " + nuevaSalud.ToString();
    }
}
