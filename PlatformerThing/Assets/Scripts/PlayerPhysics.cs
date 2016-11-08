using UnityEngine;
using System.Collections;

public class PlayerPhysics : MonoBehaviour {

    public float jumpHeight = 10f;
    public float jumpTolerance = 0.5f;

    private Rigidbody rb;
    private RaycastHit hit;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// To 
    /// </summary>
    /// <param name="moveAmount"></param>
    public void Move(Vector2 moveAmount)
    {
        //transform.Translate(moveAmount);

        Vector3 newPos = transform.position;
        newPos.x += moveAmount.x;
        newPos.y += moveAmount.y;

        transform.position = newPos;

    }

    public void Jump()
    {
        // If I'm not in the air already, then jump
        
        if(Physics.Raycast(transform.position,Vector3.down,out hit, jumpTolerance))
        {
            rb.AddForce(Vector3.up * jumpHeight);
        }
    }
}
