using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Spike Trap"); 
            collision.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
        }
    }
}
