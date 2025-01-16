using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;  // Initial health of the enemy

    // Method to handle taking damage
    public void TakeDamage(int Damage)
    {
        health -= Damage;

        // If health reaches 0 or below, destroy the enemy
        if (health <= 0)
        {
            Die();
        }
    }

    // Method to destroy the enemy (or play death animation, etc.)
    private void Die()
    {
        Debug.Log("EnemyCow has died!");

        // Destroy the enemy GameObject
        Destroy(gameObject);
    }
}
