using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speedX;
    [SerializeField] private float speedY;
    [SerializeField] private GameObject ground;

    private Vector2 currentScale;
    private Rigidbody2D body;
    private float lowHeight;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        currentScale = transform.localScale;
        lowHeight = ground.transform.position.y;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");

        body.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speedX, body.linearVelocityY);

        Debug.Log(body.linearVelocity);

        //flip based on direction
        if (horizontalInput > 0)
        {
            transform.localScale = currentScale;
        } else
        {
            transform.localScale = new Vector2(-currentScale.x, currentScale.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            body.linearVelocity = new Vector2(body.linearVelocityX, speedY);
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PainObstacle"))
        {
            Destroy(gameObject);
        }
    }
}
