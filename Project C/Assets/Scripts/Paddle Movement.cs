using UnityEditorInternal;
using UnityEngine;

public abstract class PaddleMovement : MonoBehaviour
{
    private float speed = 5f;
    private float boundaryY = 3.5f;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = GetMoveInput();
        float newY = transform.position.y + (moveInput.y * speed * Time.deltaTime);
        if (newY > boundaryY) newY = boundaryY;
        if (newY < -boundaryY) newY = -boundaryY;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    protected abstract Vector2 GetMoveInput();
}
