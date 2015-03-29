using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    // Declaration of Public Variables
    public Transform target;
    public float smoothing = 5.0f;

    // Declaration of Private Variables
    private Vector3 offset;

    // Start is called just before any of the Update methods is called the first time
    void Start()
    {
        offset = transform.position - target.position;
    }

    // This function is called every fixed framerate frame, if the MonoBehaviour is enabled
    public void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
