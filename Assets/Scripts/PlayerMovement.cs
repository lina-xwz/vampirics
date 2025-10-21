using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float Speed = 3f;
    [SerializeField] private float JumpForce = 3f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            Run();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, Speed * Time.deltaTime);
    }

    private void Jump()
    {
        rb.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
    }

}