using UnityEngine;
using System.Collections;

public class DoorSwitchActivator : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    void OnCollisionStay(Collision c)
    {
        if (c.gameObject.tag == "doorSwitch")
        {
            c.gameObject.GetComponent<DoorController>().active = true;
        }
    }
    void OnCollisionExit(Collision c)
    {
        if (c.gameObject.tag == "doorSwitch")
        {
            c.gameObject.GetComponent<DoorController>().active = false;
        }
    }
}
