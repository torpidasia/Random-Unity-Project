using UnityEngine;

public class umar : MonoBehaviour
{
    public float speed = 10.0f;
    public float acceleration = 5.0f;
    public float turnSpeed = 2.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Apply acceleration and limit speed
        rb.AddForce(transform.forward * moveVertical * acceleration);
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, speed);

        // Apply turning
        float turnAmount = moveHorizontal * turnSpeed;
        Quaternion turnOffset = Quaternion.Euler(0, turnAmount, 0);
        rb.MoveRotation(rb.rotation * turnOffset);
    }
}
