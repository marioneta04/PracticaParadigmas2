using UnityEngine;
using UnityEngine.Events;

public class GameStateManager : MonoBehaviour
{
    public UnityEvent OnGameStart;
    public UnityEvent OnGamePause;

    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) // Enter para iniciar
        {
            OnGameStart.Invoke();
            isPaused = false;
            Debug.Log("Juego iniciado");
        }

        if (Input.GetKeyDown(KeyCode.Escape)) // Esc para pausar
        {
            isPaused = !isPaused;

            if (isPaused)
            {
                OnGamePause.Invoke();
                Debug.Log("Juego pausado");
            }
            else
            {
                OnGameStart.Invoke();
                Debug.Log("Juego reanudado");
            }
        }
    }
}
