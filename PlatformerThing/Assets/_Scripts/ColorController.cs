using UnityEngine;

public class ColorController: MonoBehaviour
{

    public enum ColorEnum { red, black, white }
    public ColorEnum color;

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
    public void ChangeColor(ColorEnum changeToColor)
    {
        color = changeToColor;
        if(tag == "colorWall" || tag == "Player" || tag =="Player2")
        {
            switch (color)
            {
                case (ColorEnum.red):
                    gameObject.GetComponent<Renderer>().material = red;
                    gameObject.layer = 8;
                    break;
                case (ColorEnum.black):
                    gameObject.GetComponent<Renderer>().material = black;
                    gameObject.layer = 10;
                    break;
                case (ColorEnum.white):
                    gameObject.GetComponent<Renderer>().material = white;
                    gameObject.layer = 9;
                    break;
                default:
                    gameObject.GetComponent<Renderer>().material = black;
                    gameObject.layer = 10;
                    break;
            }
        }
        else if(tag == "teleporter")
        {
            switch (color)
            {
                case (ColorEnum.red):
                    gameObject.GetComponent<Renderer>().material = red;
                    gameObject.GetComponentInChildren<ParticleSystem>().startColor = new Color(1, 0, 0, 1);
                    gameObject.layer = 17;
                    break;
                case (ColorEnum.black):
                    gameObject.GetComponent<Renderer>().material = black;
                    gameObject.GetComponentInChildren<ParticleSystem>().startColor = new Color(0, 0, 0, 1);
                    gameObject.layer = 15;
                    break;
                case (ColorEnum.white):
                    gameObject.GetComponent<Renderer>().material = white;
                    gameObject.GetComponentInChildren<ParticleSystem>().startColor = new Color(1, 1, 1, 1);
                    gameObject.layer = 16;
                    break;
                default:
                    gameObject.GetComponent<Renderer>().material = black;
                    gameObject.layer = 15;
                    break;
            }
        }
        else if(tag == "winner")
        {
            switch (color)
            {
                case (ColorEnum.red):
                    gameObject.GetComponent<Renderer>().material = red;
                    gameObject.layer = 13;
                    break;
                case (ColorEnum.black):
                    gameObject.GetComponent<Renderer>().material = black;
                    gameObject.layer = 11;
                    break;
                case (ColorEnum.white):
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
