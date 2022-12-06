using UnityEngine;
using System.Collections;
public class BoxMover : MonoBehaviour
{
    
    public float speed = 0;
    public float strafe_speed = 0;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float contolled_walk_speed = Input.GetAxis("Horizontal") * speed;
        float controlled_strafe_speed = Input.GetAxis("Vertical") * strafe_speed;

        rb.AddForce(contolled_walk_speed, 0, controlled_strafe_speed);
    }
}
