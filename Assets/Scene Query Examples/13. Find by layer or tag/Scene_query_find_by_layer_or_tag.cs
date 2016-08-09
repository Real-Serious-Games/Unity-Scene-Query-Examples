using UnityEngine;
using System.Collections;
using System.Linq;
using RSG.Scene.Query;

public class Scene_query_find_by_layer_or_tag : MonoBehaviour
{
	void Start ()
    {
        var sceneQuery = new SceneQuery();

        var pedestrians = sceneQuery.SelectAll(".Pedestrian");
        foreach (var pedestrian in pedestrians)
        {
            Debug.Log("Found pedestrian: " + pedestrian.name);
        }
    }
}
