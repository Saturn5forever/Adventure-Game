using UnityEditor.Callbacks;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.2f;
    public Vector3 offset = new Vector3(0f, 0f, -10f);

    private Vector3 _currentVelocity = Vector3.zero;

    void LateUpdate()
    {
        if(target != null)
        {
            Vector3 targetPosition = target.transform.position + offset;

            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, smoothTime);
        }
        
    }
}
