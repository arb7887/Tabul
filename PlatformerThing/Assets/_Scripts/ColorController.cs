using UnityEngine;

public class ColorController: MonoBehaviour
{

    public enum Color { red, black, white }
    public Color color;

    public Material red;
    public Material black;
    public Material white;


    void Start()
    {
        // Set color
        ChangeColor(color);
    }

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To change the color of the current object
    /// </summary>
    public void ChangeColor(Color changeToColor)
    {
        color = changeToColor;
        if(tag != "winner")
        {
            switch (color)
            {
                case (Color.red):
                    gameObject.GetComponent<Renderer>().material = red;
                    gameObject.layer = 8;
                    break;
                case (Color.black):
                    gameObject.GetComponent<Renderer>().material = black;
                    gameObject.layer = 10;
                    break;
                case (Color.white):
                    gameObject.GetComponent<Renderer>().material = white;
                    gameObject.layer = 9;
                    break;
                default:
                    gameObject.GetComponent<Renderer>().material = black;
                    gameObject.layer = 10;
                    break;
            }
        }
        else
        {
            switch (color)
            {
                case (Color.red):
                    gameObject.GetComponent<Renderer>().material = red;
                    gameObject.layer = 13;
                    break;
                case (Color.black):
                    gameObject.GetComponent<Renderer>().material = black;
                    gameObject.layer = 11;
                    break;
                case (Color.white):
                    gameObject.GetComponent<Renderer>().material = white;
                    gameObject.layer = 12;
                    break;
                default:
                    gameObject.GetComponent<Renderer>().material = black;
                    gameObject.layer = 11;
                    break;
            }
        }
    
    }


}
