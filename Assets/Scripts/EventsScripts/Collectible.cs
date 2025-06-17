using UnityEngine;
using UnityEngine.Events;

public class Collectible : MonoBehaviour
{
    [System.Serializable]
    public class ItemCollectedEvent : UnityEvent<string> { }

    public string itemName = "Item"; 
    public ItemCollectedEvent onCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            onCollected.Invoke(itemName);
            Destroy(gameObject); 
        }
    }
}
