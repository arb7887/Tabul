using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour {

    #region Fields

    public Text timerText;          // The UI element for the timer
    public Transform spawnPoint;    // The spawn point of the player
    public int numWinBlocks = 1;    // How many win blocks are there?

    private float timePassed = 0f;  // How much time has passed
    private GameObject player;      // A reference to the player so that we can move them
    public int currentWinBlocks;    // The current number of winning blocks left
    private bool gameOver;          // Is the game over? 
    private MenuControlls menuController;

    #endregion

    // Use this for initialization
    void Start ()
    {
        menuController = GameObject.FindObjectOfType<MenuControlls>();

        currentWinBlocks = numWinBlocks;

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
        if (!gameOver)
        {
            timePassed += Time.deltaTime;
            timerText.text = (Math.Truncate(10 * timePassed) / 10).ToString();
        }
    }

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To show the winning UI, 
    /// stop the timer and rate the player based on the
    /// time that they got
    /// </summary>
    public void Win()
    {
        gameOver = true;
        menuController.ShowGameOverUI();
    }



    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To itterate down on the number
    /// of winning blocks, and if it less then 0 then call win
    /// </summary>
   public void HitWinBlock()
    {
        currentWinBlocks--;

        if(currentWinBlocks <= 0)
        {
            Win();
        }
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


    
}
