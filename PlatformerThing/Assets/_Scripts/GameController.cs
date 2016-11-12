using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour {

    public Text timerText;
    public Transform spawnPoint;

    private float timePassed = 0f;
    private GameObject player;

	// Use this for initialization
	void Start ()
    {
        // Get the player gameobject
        player = GameObject.FindGameObjectWithTag("Player");
        if(player == null)
        {
            Debug.Log("There is no player!!!!");
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        timePassed += Time.deltaTime;
        
        timerText.text = (Math.Truncate(10 * timePassed) / 10).ToString();
	}

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To show the winning UI, 
    /// stop the timer and rate the player based on the
    /// time that they got
    /// </summary>
    public void Win()
    {
        Debug.Log("Winner!");
        // Update the UI 
        // Give the player a score
    }

    /// <summary>
    /// Author: Ben hoffman
    /// Purpose of method: To set teh player back at the spawn point
    /// </summary>
    public void Lose()
    {
        // Spawn the player at the spawn point
        player.transform.position = spawnPoint.position;
        player.transform.rotation = spawnPoint.rotation;
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To re-load the current level
    /// </summary>
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    /// <summary>
    /// Author: Ben Hoffman
    /// purpose of method: To load the main menu level
    /// </summary>
    public void MainMenu()
    {
        // Load the main menu level
    }
}
