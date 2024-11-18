using System.Collections;
using UnityEngine;
using Fungus;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject[] customerPrefabs; // Array of customer prefabs for variety
    public Transform[] spawnPoints;      // Specific spawn locations for customers
    public int maxCustomerSlots = 3;     // Maximum number of customer slots

    public string spawnDialogBlockName = "CustomerSpawnDialog"; // Block name in Flowchart to display dialog

    private void Start()
    {
        // Start checking for available slots
        StartCoroutine(SpawnCustomerRoutine());
    }

    IEnumerator SpawnCustomerRoutine()
    {
        while (true)
        {
            // Check if the spawner has fewer than the max customer slots
            if (transform.childCount < maxCustomerSlots)
            {
                // Wait for a random time between 1-7 seconds
                float waitTime = Random.Range(1f, 7f);
                yield return new WaitForSeconds(waitTime);

                // Only spawn a customer if the slot is still available
                if (transform.childCount < maxCustomerSlots)
                {
                    SpawnCustomer();
                }
            }

            // Wait a short period before checking again
            yield return new WaitForSeconds(0.5f);
        }
    }

    void SpawnCustomer()
    {
        // Select a random spawn point
        int randomSpawnIndex = Random.Range(0, spawnPoints.Length);
        Transform selectedSpawnPoint = spawnPoints[randomSpawnIndex];

        // If the selected spawn point has no children, spawn a customer here
        if (selectedSpawnPoint.childCount == 0)
        {
            // Select a random customer prefab from the array
            GameObject selectedCustomerPrefab = customerPrefabs[Random.Range(0, customerPrefabs.Length)];

            // Instantiate the selected customer prefab and set its parent to the spawn point
            GameObject newCustomer = Instantiate(selectedCustomerPrefab, selectedSpawnPoint.position, Quaternion.identity);
            newCustomer.transform.SetParent(selectedSpawnPoint);

            // Trigger Fungus dialog box when the customer is spawned
            
        }
    }
}
