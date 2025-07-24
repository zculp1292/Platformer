using UnityEngine;

public class JumpReset : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Movement movement = collision.gameObject.GetComponent<Movement>();
        bool jumpState = movement.GetJump();

        if (movement != null && !jumpState)
        {
            movement.ResetJump();
        }
    }
}
