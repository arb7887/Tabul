using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerPhysics))]
[RequireComponent(typeof(Rigidbody))]

public class PlayerInput : MonoBehaviour {

    // Player character stuff
    public float speed = 8f;
    public float acceleration = 12f;

    private float currentSpeed;
    private float targetSpeed;
    private Vector2 ammountToMove;

    private PlayerPhysics playerPhysics;

	// Use this for initialization
	void Start ()
    {
        playerPhysics = GetComponent<PlayerPhysics>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        targetSpeed = Input.GetAxisRaw("Horizontal") * speed;
        currentSpeed = IncrementTowards(currentSpeed, targetSpeed, acceleration);

        ammountToMove = new Vector2(currentSpeed, 0f);
        playerPhysics.Move(ammountToMove * Time.deltaTime);

        if (Input.GetButton("Jump"))
        {
            playerPhysics.Jump();
        }
	}

    private float IncrementTowards(float n, float target, float accel)
    {
        if(n == target)
        {
            return n;
        }
        else
        {
            float dir = Mathf.Sign(target - n);
            n += accel * Time.deltaTime * dir;
            return (dir == Mathf.Sign(target - n)) ? n : target;
        }
    }
}
