using UnityEngine;
using System.Collections;

/// <summary>
/// Author: Ben Hoffman
/// Purpose of class: To have an object flash between specified colors
/// </summary>
[RequireComponent(typeof(ColorController))]
public class FlashingGround : MonoBehaviour {

    #region Fields
    public float flashSpeed;
    public ColorController.Color[] possibleColors;    

    private int currentColor = 0;
    private float timeSinceLastSwitch;
    private ColorController colorController;
    #endregion

    // Use this for initialization
    void Start ()
    {
        colorController = GetComponent<ColorController>();
        timeSinceLastSwitch = flashSpeed;

        if(possibleColors != null)
        {
            currentColor = 0;

            colorController.ChangeColor(possibleColors[currentColor]);
        }
        else
        {
            Debug.Log("You need some colors in that array!");
        }

	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(timeSinceLastSwitch >= flashSpeed)
        {
            // change the color
            ChangeColor();
        }
        else
        {
            timeSinceLastSwitch += Time.deltaTime;
        }
	}

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To switch between the colors
    /// </summary>
    private void ChangeColor()
    {
        currentColor++;
        if(currentColor > possibleColors.Length)
        {
            currentColor = 0;
        }

        colorController.ChangeColor(possibleColors[0]);
    }
}
