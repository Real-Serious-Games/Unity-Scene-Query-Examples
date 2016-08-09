using UnityEngine;
using System.Collections;
using System.Linq;
using RSG.Scene.Query;

public class Scene_query_find_child_object_directly_under_parent : MonoBehaviour
{
	void Start ()
    {
        var sceneQuery = new SceneQuery();

        var child = sceneQuery.SelectOne("Parent/Child");
        Debug.Log("Found child object: " + child.name);
    }
}
