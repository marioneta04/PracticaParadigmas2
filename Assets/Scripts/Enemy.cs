using UnityEngine;

public class Enemy : MonoBehaviour, IPresentacion, ITakeDamage
{
    public EnemyData data;
    private int vidaActual;

    private void Start()
    {
        vidaActual = data.vida;
    }

    public void Accion()
    {
        Debug.Log($"{data.nombre} dice: {data.saludo}");
    }

    public void TakeDamage(int amount)
    {
        vidaActual -= amount;
        Debug.Log($"{data.nombre} recibió {amount} de daño. Vida restante: {vidaActual}");

        if (vidaActual <= 0)
        {
            Morir();
        }
    }

    private void Morir()
    {
        Debug.Log($"{data.nombre} ha muerto.");
        Destroy(gameObject);
    }
}