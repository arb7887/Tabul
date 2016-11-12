using UnityEngine;
using System.Collections;

/// <summary>
/// Author: Ben Hoffman
/// Purpose of class: to offer some button 
/// controlls that I will use throughout the game
/// </summary>
public class MainMenu : MonoBehaviour {

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To load in the given level
    /// </summary>
    /// <param name="level"></param>
    public void LoadLevel(int level)
    {
        Application.LoadLevel(level);
    }

    /// <summary>
    /// Author: Ben Hoffman
    /// purpose of method: To load the main menu level
    /// </summary>
    public void LoadMenu()
    {
        // Load the main menu level
        Application.LoadLevel(0);
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
    /// Purpose of method: To Quit out of the game
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
}
