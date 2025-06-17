using UnityEngine;
using UnityEngine.Events;

public class NPC : MonoBehaviour
{
    public UnityEvent OnInteract;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnInteract?.Invoke();
            Debug.Log("Interacción con NPC");
        }
    }
}
