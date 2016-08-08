using UnityEngine;
using System.Collections;

public class Find_object_by_type : MonoBehaviour
{
	void Start ()
    {
        var leaderboard = GameObject.FindObjectOfType<Leaderboard>();
        Debug.Log("Found leaderboard: " + leaderboard.name);	
	}
}
