using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float spawnHeight = 1f; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)) 
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        Vector3 spawnPosition =  new Vector3(0, spawnHeight, 0);
        Instantiate(objectPrefab, spawnPosition, Quaternion.identity);
    }
}
