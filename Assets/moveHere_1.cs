using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHere_1 : MonoBehaviour {

    public GameObject door;
    public GameObject player;
    public GameObject box;
    public bool target_enter;
    private Vector3 player_position;
    private Vector3 box_position;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        player_position = player.transform.position;
        box_position = box.transform.position;
        if (!target_enter && Math.Abs(player_position.x - box_position.x) < 1.7 && Math.Abs(player_position.z - box_position.z) < 1.5)
        {
            target_enter = true;
            door.GetComponent<door>().doorOpen();
        }
    }



}
