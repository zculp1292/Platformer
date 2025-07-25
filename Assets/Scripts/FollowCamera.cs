using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform cameraTarget;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(cameraTarget.position.x, cameraTarget.position.y + 2, -10);
    }
}
