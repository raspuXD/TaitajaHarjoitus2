using UnityEngine;

public class CowMilkProducer : MonoBehaviour
{
    public GameObject milkPrefab;
    public Transform spawnPoint;
    public float spawnInterval = 5f; // Time between each milk spawn

    public GameObject lastMilk;

    private float lastSpawnTime;

    void Update()
    {
        // Only start counting down if there is no milk
        if (lastMilk == null)
        {
            if (Time.time - lastSpawnTime > spawnInterval) // Check if it's time to spawn milk
            {
                SpawnMilk();
                lastSpawnTime = Time.time; // Reset the timer
            }
        }
    }

    void SpawnMilk()
    {
        lastMilk = Instantiate(milkPrefab, spawnPoint.position, Quaternion.identity);
    }
}