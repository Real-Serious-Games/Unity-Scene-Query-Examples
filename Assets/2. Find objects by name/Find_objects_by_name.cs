using UnityEngine;
using System.Collections;
using System.Linq;

public class Find_objects_by_name : MonoBehaviour {

	void Start ()
    {
        var pedestrians = GameObject.FindObjectsOfType<GameObject>()
            .Cast<GameObject>()
            .Where(gameObject => gameObject.name == "Pedestrian")
            .ToArray();

        foreach (var pedestrian in pedestrians)
        {
            Debug.Log("Found game object " + pedestrian.name);
        }
    }
}
