using UnityEngine;

public class CowMilkProducer : MonoBehaviour
{
    public GameObject milkPrefab;  // Assign your milk prefab here
    public float spawnRadius = 2f; // Radius to check for existing milk
    public float spawnInterval = 5f; // Time between each milk spawn

    private float lastSpawnTime;

    void Update()
    {
        if (Time.time - lastSpawnTime > spawnInterval) // Check if it's time to spawn milk
        {
            TrySpawnMilk();
            lastSpawnTime = Time.time;
        }
    }

    void TrySpawnMilk()
    {
        // Check for nearby milk objects
        Collider[] colliders = Physics.OverlapSphere(transform.position, spawnRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Milk")) // Make sure the collider is a milk object
            {
                return; // If there is already milk, don't spawn more
            }
        }

        // If no milk is nearby, spawn a new one
        SpawnMilk();
    }

    void SpawnMilk()
    {
        Vector3 spawnPosition = transform.position + new Vector3(Random.Range(-spawnRadius, spawnRadius), 0, Random.Range(-spawnRadius, spawnRadius));
        Instantiate(milkPrefab, spawnPosition, Quaternion.identity);
    }
}
