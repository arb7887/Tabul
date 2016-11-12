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
        if(tag == "Player2")
        {
            targetSpeed = Player2Input();
        }
        else
        {
            targetSpeed = Player1Input();
        }

        currentSpeed = IncrementTowards(currentSpeed, targetSpeed, acceleration);

        ammountToMove = new Vector2(currentSpeed, 0f);
        playerPhysics.Move(ammountToMove * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && tag == "Player")
        {
            playerPhysics.Jump();
        }
        else if(Input.GetButtonDown("Jump2") && tag == "Player2")
        {
            playerPhysics.Jump();
        }
	}

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To calculate the acceleration for
    /// the player
    /// </summary>
    /// <param name="n">Current speed</param>
    /// <param name="target">target speed</param>
    /// <param name="accel"></param>
    /// <returns></returns>
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


    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To get input for the first player
    /// </summary>
    private float Player1Input()
    {
        return Input.GetAxisRaw("Horizontal") * speed;

    }

    /// <summary>
    /// Author: Ben hoffman
    /// Purpose of method: To get the input from the second player
    /// </summary>
    private float Player2Input()
    {
        return Input.GetAxisRaw("Horizontal2") * speed;
    }
}
