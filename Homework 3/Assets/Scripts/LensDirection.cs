using Unity.XR.CoreUtils;
using UnityEngine;

public class LensDirection : MonoBehaviour
{
    public Transform viewTarget;
    public Transform mainCamera;
    public Transform mag;
    //private Quaternion prevRotation;

    void Update()
    {
        viewTarget.position = (transform.position - mainCamera.position).normalized * 8.0f + transform.position;
        transform.LookAt(viewTarget, mag.up);
    }
    
}