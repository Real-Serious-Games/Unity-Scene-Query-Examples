using UnityEngine;
using System.Collections;
using RSG.Scene.Query;

public class Scene_query_find_object_by_name : MonoBehaviour {

	void Start ()
    {
        var sceneQuery = new SceneQuery();

        var player = sceneQuery.SelectOne("Player");
        Debug.Log("Found game object " + player.name);
	}
}
