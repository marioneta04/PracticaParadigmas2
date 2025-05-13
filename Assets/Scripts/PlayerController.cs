using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float detectionRadius = 3f;
    public int damageAmount = 25;

    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.R))
        {
            LlamarAccionEnemigoMasCercano();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            AtacarEnemigos();
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }

    void LlamarAccionEnemigoMasCercano()
    {
        Enemy enemigoMasCercano = null;
        float menorDistancia = Mathf.Infinity;

        foreach (Enemy enemigo in FindObjectsByType<Enemy>(FindObjectsSortMode.None))
        {
            float distancia = Vector2.Distance(transform.position, enemigo.transform.position);
            if (distancia < menorDistancia && distancia <= detectionRadius)
            {
                menorDistancia = distancia;
                enemigoMasCercano = enemigo;
            }
        }

        if (enemigoMasCercano != null)
        {
            enemigoMasCercano.Accion();
        }
    }

    void AtacarEnemigos()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, detectionRadius);

        foreach (Collider2D col in colliders)
        {
            ITakeDamage target = col.GetComponent<ITakeDamage>();
            if (target != null)
            {
                target.TakeDamage(damageAmount);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}
