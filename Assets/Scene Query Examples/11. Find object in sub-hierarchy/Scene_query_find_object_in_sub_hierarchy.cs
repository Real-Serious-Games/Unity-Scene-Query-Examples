using UnityEngine;
using System.Collections;
using System.Linq;
using RSG.Scene.Query;

public class Scene_query_find_object_in_sub_hierarchy : MonoBehaviour
{
	void Start ()
    {
        var sceneQuery = new SceneQuery();

        var child = sceneQuery.SelectOne("Parent>Child");
        Debug.Log("Found child object: " + child.name);
    }
}
