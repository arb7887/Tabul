using UnityEngine;
using System.Collections;

/// <summary>
/// Author: Ben Hoffman
/// Purpose of class: To have any object with this script on it 
/// teleport a colliding object
/// </summary>
[RequireComponent(typeof(ColorController))]
public class Teleporter : MonoBehaviour {

    public Transform teleportLocation;  // This is where this teleporter will send you

    /// <summary>
    /// Author: Ben Hoffman
    /// Purpose of method: To have the given gam eobject teleport
    /// to my field positoin of teleport location
    /// </summary>
    /// <param name="toTeleport">The game object that I am moving</param>
    public void Teleport(GameObject toTeleport)
    {
        toTeleport.transform.position = teleportLocation.position;
        toTeleport.transform.rotation = teleportLocation.rotation;
    }
}
