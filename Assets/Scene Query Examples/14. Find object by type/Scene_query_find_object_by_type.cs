using UnityEngine;
using System.Collections;
using System.Linq;
using RSG.Scene.Query;

public class Scene_query_find_object_by_type : MonoBehaviour
{
	void Start ()
    {
        var sceneQuery = new SceneQuery();

        var player = sceneQuery.SelectOne<Player>();
        Debug.Log("Found player: " + player.name);
    }
}
