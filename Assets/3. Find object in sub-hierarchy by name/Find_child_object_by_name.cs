using UnityEngine;
using System.Collections;
using System.Linq;

public class Find_child_object_by_name : MonoBehaviour
{
	void Start ()
    {
        var parent = GameObject.Find("Parent");
        var child = parent.transform.FindChild("Child");
        Debug.Log("Found child object: " + child.name);
    }
}
