using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [Header("Salud del jugador")]
    public int salud = 100;

    [System.Serializable]
    public class SaludCambioEvent : UnityEvent<int> { }

    public SaludCambioEvent OnSaludCambio;

    public void TomarDaño(int daño)
    {
        salud -= daño;
        salud = Mathf.Max(salud, 0); 

        if (OnSaludCambio != null)
        {
            OnSaludCambio.Invoke(salud);
        }
    }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TomarDaño(10);
        }
    }
}
