using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direction;
    private float speed = 3f;
    private float maxSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-0.5f, 0.5f)).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            direction.x = -direction.x;
            speed = Mathf.Min(speed + 0.5f, maxSpeed);
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            direction.y = -direction.y;
        }
        else if (collision.gameObject.CompareTag("Goal"))
        {
            //Replace with goal logic later
            direction.x = -direction.x;
        }
    }
}
