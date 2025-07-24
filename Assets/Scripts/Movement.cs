using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] InputAction right;
    [SerializeField] InputAction left;

    Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        right.Enable();
        left.Enable();

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (right.IsPressed())
        {
            rb.AddRelativeForce(Vector3.right * moveSpeed);
        }
        if (left.IsPressed())
        {
            rb.AddRelativeForce(Vector3.left * moveSpeed);
        }
    }
}
