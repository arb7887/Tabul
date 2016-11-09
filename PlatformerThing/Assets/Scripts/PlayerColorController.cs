using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ColorController))]
public class PlayerColorController : MonoBehaviour {

    private ColorController colorControls;

	// Use this for initialization
	void Start ()
    {
        colorControls = GetComponent<ColorController>();
	}
	

    void OnCollisionEnter(Collision c)
    {
        ColorController cColor = c.gameObject.GetComponent<ColorController>();

        if(cColor != null && c.gameObject.tag == "changer" && c.gameObject.layer != gameObject.layer)
        {
            colorControls.ChangeColor(cColor.color);
        }

        // If the collision is with the death bounds, then make a short pause, and then show the menu
        // That gives the options to restart or go to the main menu
        if(c.gameObject.tag == "bounds")
        {
            // Reset the players spot
        }
    }

}
