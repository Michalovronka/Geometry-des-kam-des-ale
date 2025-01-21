using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 6f;
    public float jumpForce = 500f;


    private bool _isGrounded = true;


    void Update()
    {
        Move();
        if (Input.GetMouseButton(0) && _isGrounded)
        {
            Jump();
        }
    }

    void Move()
    {
        rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);
    }

    void Jump()
    {
        _isGrounded = false;
        rb.AddForce(Vector2.up * jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("FLOOR") || other.collider.CompareTag("BLOCKS"))
        {
            _isGrounded = true;
        }
        if (other.collider.CompareTag("SPIKE"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
