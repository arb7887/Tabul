using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuControlls : MainMenu {

    #region Fields
    public Button resumeButton;
    public Button menuButton;
    public Button quitButton;
    public Text gameOverText;
    public GameObject[] stars;

    private bool paused;

    #endregion

    // Use this for initialization
    void Start ()
    {
        foreach (GameObject star in stars)
        {
            star.SetActive(false);
        }

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
    /// Purpose of method: To draw the stars for after you win
    /// </summary>
    /// <param name="numStars">The number of stars to draw</param>
    public void DrawStars(int numStars)
    {
        if(stars != null)
        {
            for(int i = 0; i < numStars; i++)
            {
                stars[i].SetActive(true);
            }
        }
    }

}
