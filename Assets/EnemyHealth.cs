using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("Enemy Settings")]
    public int maxHealth = 1;

    [Header("VFX")]
    public GameObject hitEffectPrefab;

    private int currentHealth;

    void Awake()
    {
        
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (hitEffectPrefab != null)
        {
            Instantiate(
                hitEffectPrefab,
                transform.position,
                Quaternion.identity
            );
        }

        // Enemy chết
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
