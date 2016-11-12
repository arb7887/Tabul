using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameController : MonoBehaviour {

    #region Fields

    public Text timerText;          // The UI element for the timer
    public Transform player1Spawn;  // The spawn point of the player
    public Transform player2Spawn;  //
    public int numWinBlocks = 1;    // How many win blocks are there?
    public float threeStarTime = 60f;

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
        Debug.Log(CalculateScore());
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
    public void Lose(GameObject player)
    {
        if(player.tag == "Player")
        {
            // Spawn the player at the spawn point
            player.transform.position = player1Spawn.position;
            player.transform.rotation = player1Spawn.rotation;
        }
        else if(player.tag == "Player2")
        {
            player.transform.position = player2Spawn.position;
            player.transform.rotation = player2Spawn.rotation;
        }

        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To determine how many stars
    /// the play has earned
    /// </summary>
    /// <returns></returns>
    private int CalculateScore()
    {
        if(timePassed <= threeStarTime)
        {
            return 3;
        }
        else if(timePassed < threeStarTime + 0.3f * (threeStarTime))
        {
            return 2;
        }
        else if (timePassed < threeStarTime + 0.6f * (threeStarTime))
        {
            return 1;
        }

        return 0;
    }
    
}
