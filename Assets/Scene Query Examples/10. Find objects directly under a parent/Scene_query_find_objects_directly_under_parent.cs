using UnityEngine;
using System.Collections;
using System.Linq;
using RSG.Scene.Query;

public class Scene_query_find_objects_directly_under_parent : MonoBehaviour
{
	void Start ()
    {
        var sceneQuery = new SceneQuery();

        var children = sceneQuery.SelectAll("Parent/Child");
        foreach (var child in children)
        {
            Debug.Log("Found child object: " + child.name);
        }
    }
}
