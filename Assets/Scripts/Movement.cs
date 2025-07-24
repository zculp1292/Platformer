using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpStrength = 100f;
    [SerializeField] InputAction right;
    [SerializeField] InputAction left;
    [SerializeField] InputAction jump;

    Rigidbody rb;
    bool canJump = true;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        right.Enable();
        left.Enable();
        jump.Enable();

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        if (right.IsPressed())
        {
            rb.AddRelativeForce(Vector3.right * moveSpeed * Time.fixedDeltaTime);
        }
        if (left.IsPressed())
        {
            rb.AddRelativeForce(Vector3.left * moveSpeed * Time.fixedDeltaTime);
        }
    }

    void Jump()
    {
        if (jump.IsPressed() && canJump)
        {
            canJump = false;
            moveSpeed /= 2;

            rb.AddRelativeForce(Vector3.up * jumpStrength);
        }
    }

    public void ResetJump()
    {
        canJump = true;
        moveSpeed *= 2;
    }

    public bool GetJump()
    {
        return canJump;
    }
}
