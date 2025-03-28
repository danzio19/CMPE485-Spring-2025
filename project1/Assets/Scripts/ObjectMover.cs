using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public float speed = 5f;

    public Rigidbody rb;

    // void Start()
    // {
    //     rb = GetComponent<Rigidbody>(); 
    // }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, moveZ) * speed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }
}
