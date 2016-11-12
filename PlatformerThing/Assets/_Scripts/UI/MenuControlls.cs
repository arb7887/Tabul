using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuControlls : MainMenu {

    #region Fields
    public Button resumeButton;
    public Button menuButton;
    public Button quitButton;
    public Text gameOverText;

    private bool paused;

    #endregion

    // Use this for initialization
    void Start ()
    {
        gameOverText.text = "";
        HidePauseUI();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update ()
    {
        // Check if we are pausing
        if (Input.GetButtonDown("Cancel"))
        {
            TogglePause();
        }
	}
    
    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To Toggle whether we are paused or not
    /// </summary>
    public void TogglePause()
    {
        if (!paused)
        {
            Time.timeScale = 0f;
            paused = true;
            ShowPauseUI();
        }
        else
        {
            Time.timeScale = 1f;
            paused = false;
            HidePauseUI();
        }       
    }

    

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To show the game over
    /// UI, like the restart button, quit button and menu button
    /// </summary>
    public void ShowGameOverUI()
    {
        gameOverText.text = "Finished!";
        ShowPauseUI();
    }

    /// <summary>
    /// Author: Ben Hoffmna
    /// Purpose of method: To SHOW the pause menu
    /// UI
    /// </summary>
    private void ShowPauseUI()
    {
        quitButton.gameObject.SetActive(true);
        resumeButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
    }

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To HIDE the pause menu
    /// </summary>
    private void HidePauseUI()
    {
        quitButton.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(false);
        menuButton.gameObject.SetActive(false);
    }

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To return either 0,1,2,3 
    /// depending on how long it took the player to complete
    /// the level
    /// </summary>
    /// <param name="time"></param>
    public void CalculateScore(float time, float threeStarSeed)
    {

    }

}
