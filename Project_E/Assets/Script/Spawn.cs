using UnityEngine;



public class Spawn : MonoBehaviour
{
    public GameObject targetPrefab;
    public Transform spawnPosition;

    public void SpawnTarget()
    {
        Instantiate(targetPrefab);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
