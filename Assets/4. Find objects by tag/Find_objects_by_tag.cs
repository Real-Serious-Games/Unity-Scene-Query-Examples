using UnityEngine;
using System.Collections;

public class Find_objects_by_tag : MonoBehaviour
{
	void Start ()
    {
	    var pedestrians = GameObject.FindGameObjectsWithTag("Pedestrian");
        foreach (var pedestrian in pedestrians)
        {
            Debug.Log("Found pedestrian: " + pedestrian.name);
        }
    }
}
