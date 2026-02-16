using Mono.Cecil;
using UnityEngine;
using UnityEngine.InputSystem;
public class HandController : MonoBehaviour
{
    public InputActionReference gripInput;
    public InputActionReference triggerInput;
    public InputActionReference indexInput;
    public InputActionReference thumbInput;

    private Animator animator;

    /*public GameObject followObject;
    private float followSpeed = 30f;
    private float rotateSpeed = 100f;
    private Transform target;
    private Rigidbody rb;
    */

    /*private void Start()
    {
        target = followObject.transform;
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        rb.interpolation = RigidbodyInterpolation.Interpolate;
        rb.mass = 20f;

        rb.position = target.position;
        rb.rotation = target.rotation;
    }*/
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!animator) return;
        float grip = gripInput.action.ReadValue<float>();
        float trigger = triggerInput.action.ReadValue<float>();
        float indexTouch = indexInput.action.ReadValue<float>();
        float thumbTouch = thumbInput.action.ReadValue<float>();

        animator.SetFloat("Grip", grip);
        animator.SetFloat("Trigger", trigger);
        animator.SetFloat("Index", indexTouch);
        animator.SetFloat("Thumb", thumbTouch);

        //PhysicsMove();
    }

    /*private void PhysicsMove()
    {
        //Position
        var distance = Vector3.Distance(target.position, transform.position);
        rb.linearVelocity = (target.position - transform.position).normalized * (followSpeed * distance);
        //Rotation
        var q = target.rotation * Quaternion.Inverse(rb.rotation);
        q.ToAngleAxis(out float angle, out Vector3 axis);
        rb.angularVelocity = axis * (angle * Mathf.Deg2Rad * rotateSpeed);
    }*/
}
