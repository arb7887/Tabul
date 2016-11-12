using UnityEngine;
using System.Collections;

public class StationaryNumbers : MonoBehaviour {

    public GameObject number;
    public ColorController.Color color;
	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        color = gameObject.GetComponent<ColorController>().color;
        Vector3 newPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + .5f, gameObject.transform.position.z - .5f);
        number.transform.position = newPos;
        number.transform.rotation = Quaternion.identity;
        switch(color)
        {
            case ColorController.Color.red:
                number.GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case ColorController.Color.black:
                number.GetComponent<SpriteRenderer>().color = Color.black;
                break;
            case ColorController.Color.white:
                number.GetComponent<SpriteRenderer>().color = Color.white;
                break;
        }
	}
}
