using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    [SerializeField] private float speed = -0.05f;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb);
        rb.linearVelocityX = speed;
    }
}
