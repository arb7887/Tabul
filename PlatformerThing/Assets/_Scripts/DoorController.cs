using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour
{
    public GameObject door;
    public bool active;
    public bool up;
    public Vector3 startPos;
    public Vector3 endPos;
    private Vector3 velocity;

	// Use this for initialization
	void Start ()
    {
        startPos = door.transform.position;
        endPos = new Vector3(startPos.x, startPos.y + 1.0f, 0.0f);
        velocity = new Vector3(0.0f, .4f, 0.0f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        UpdateDoorPosition();
	}

    void UpdateDoorPosition()
    {
        // If the door is supposed to go Up
        if (up)
        {
            if (active && door.transform.position != endPos)
            {
                door.transform.position += velocity * Time.deltaTime;
            }
            else if (!active && door.transform.position != startPos)
            {
                door.transform.position -= velocity * Time.deltaTime;
            }
            if (door.transform.position.y > endPos.y)
            {
                door.transform.position = endPos;
            }
            if (door.transform.position.y < startPos.y)
            {
                door.transform.position = startPos;
            }
        }
        //If the door is supposed to go Down
        else
        {
            if (active && door.transform.position != -endPos)
            {
                door.transform.position -= velocity * Time.deltaTime;
            }
            else if (!active && door.transform.position != startPos)
            {
                door.transform.position += velocity * Time.deltaTime;
            }
            if(door.transform.position.y < -endPos.y)
            {
                door.transform.position = -endPos;
            }
            if (door.transform.position.y > startPos.y)
            {
                door.transform.position = startPos;
            }
        }
    }
}
