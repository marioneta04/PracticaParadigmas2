using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public int nivelActual = 1;

    [System.Serializable]
    public class NivelCambiadoEvent : UnityEvent<int> { }

    public NivelCambiadoEvent OnNivelCambiado;

    public void CambiarNivel(int nuevoNivel)
    {
        if (nuevoNivel < 1) // evitar niveles inválidos
            nuevoNivel = 1;

        nivelActual = nuevoNivel;

        if (OnNivelCambiado != null)
            OnNivelCambiado.Invoke(nivelActual);

        Debug.Log("Nivel cambiado a: " + nivelActual);
    }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            CambiarNivel(nivelActual + 1);
        }
    }
}
