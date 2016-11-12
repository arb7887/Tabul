using UnityEngine;
using System.Collections;

public class PlayerPhysics : MonoBehaviour {

    public float jumpHeight = 10f;
    public float jumpTolerance = 0.5f;

    private Rigidbody rb;
    private RaycastHit hit;
    private Vector3 position;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To move the player
    /// </summary>
    /// <param name="moveAmount"></param>
    public void Move(Vector2 moveAmount)
    {
        position = transform.position;
        position.x += moveAmount.x;
        position.y += moveAmount.y;

        // Set the actual transform for this object
        transform.position = position;
    }

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To add a jump force to the player
    /// </summary>
    public void Jump()
    {
        // If I'm not in the air already, then jump        
        if(Physics.Raycast(transform.position, Vector3.down, out hit, jumpTolerance))
        {
            rb.AddForce(Vector3.up * jumpHeight);
        }
    }
}
