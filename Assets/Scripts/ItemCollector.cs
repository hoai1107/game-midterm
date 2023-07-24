using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int items = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            Destroy(collision.gameObject);
            items++;
        }
    }
}
