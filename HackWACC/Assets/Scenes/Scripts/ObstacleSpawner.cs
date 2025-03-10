using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    [SerializeField] private float maxTime = 3.0f;
    [SerializeField] private float sizeRange = 0.75f;
    [SerializeField] private GameObject[] obstacles;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float timer;
    void Start()
    {
        ClearObstacles();
        SpawnObstacle();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            SpawnObstacle();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void SpawnObstacle()
    {
        
        int choice = Random.Range(0, obstacles.Length);
        Vector3 spawnPos = transform.position;
        
        GameObject obstacle = Instantiate(obstacles[choice], spawnPos, Quaternion.identity);

        Destroy(obstacle, 30f / maxTime);
    }

    private void ClearObstacles()
    {
        GameObject[] currentObstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject obstacle in currentObstacles)
        {
            Destroy(obstacle);
        }

        currentObstacles = GameObject.FindGameObjectsWithTag("PainObstacle");
        foreach (GameObject obstacle in currentObstacles)
        {
            Destroy(obstacle);
        }
    }
}
