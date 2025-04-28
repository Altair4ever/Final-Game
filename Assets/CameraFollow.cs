using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The player or object the camera follows
    public Vector3 offset; // Offset from the target position
    public float smoothSpeed = 0.125f; // Smoothness factor for camera movement

    private void LateUpdate()
    {
        if (target == null)
            return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
