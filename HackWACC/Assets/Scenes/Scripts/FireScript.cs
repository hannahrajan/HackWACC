using UnityEngine;

public class FireScript : MonoBehaviour
{
    [SerializeField] private float maxTime = 3.0f;
    public Transform smogPoint;
    public GameObject smogPrefab;
    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            SpawnSmog();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void SpawnSmog()
    {
        GameObject obstacle = Instantiate(smogPrefab, smogPoint.position, smogPoint.rotation);
        Destroy(obstacle, 5f);
    }
}
