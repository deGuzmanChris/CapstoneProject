using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target; // The target for the camera to follow
    private void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}
