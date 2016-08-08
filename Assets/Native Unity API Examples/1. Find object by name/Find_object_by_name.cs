using UnityEngine;
using System.Collections;

public class Find_object_by_name : MonoBehaviour {

	void Start ()
    {
        var player = GameObject.Find("Player");
        Debug.Log("Found game object " + player.name);
	}
}
