using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {

    public float speedY;             // How fast it will go in the Y direction
    public float speedX;             // How fast we will go in the x direction   
    public float rangeY;             // How high it will go in the Y direction
    public float rangeX;             // How far we will go in the X direction

    private Vector3 startPosition;  // This is the start position of the elevator

	// Use this for initialization
	void Start ()
    {
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To move the object in the desired direction
    /// </summary>
    private void Move()
    {
        // If we are at the start height, or less then the start height + the range,
        // then move up.
        if (transform.position.y >= startPosition.y + rangeY || transform.position.y <= startPosition.y - 0.5f)
        {
            speedY *= -1;
        }

        transform.Translate(Vector3.up * speedY * Time.deltaTime);
        // Same thing as this  
        /*position.y += speedY * Time.deltaTime;
        transform.position = position;*/
        if (transform.position.x >= startPosition.x + rangeX || transform.position.x <= startPosition.x - 0.5f)
        {
            speedX *= -1;
        }
        transform.Translate(Vector3.right * speedX * Time.deltaTime);

    }
}
