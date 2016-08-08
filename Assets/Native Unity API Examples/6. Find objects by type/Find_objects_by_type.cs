using UnityEngine;
using System.Collections;

public class Find_objects_by_type : MonoBehaviour
{
    void Start()
    {
        var pedestrians = GameObject.FindObjectsOfType<Pedestrian>();
        foreach (var pedestrian in pedestrians)
        {
            Debug.Log("Found pedestrian: " + pedestrian.name);
        }
    }
}
