using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour {

    public GameObject button_scan;
    public GameObject start_light;
    public GameObject door;
    public GameObject player_outside;
    public Material[] buttonMats;
    public GameObject inside_room;
    public bool target_enter = false;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(int keyCode)
    {
        if (!target_enter && keyCode == 1)
        {
            button_scan.transform.GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(true);
            button_scan.transform.GetChild(0).GetChild(0).GetChild(2).gameObject.SetActive(false);
            button_scan.transform.GetChild(2).GetComponent<MeshRenderer>().material = buttonMats[1];
            start_light.GetComponent<MeshRenderer>().material = buttonMats[2];
            door.GetComponent<AudioSource>().Play();
            inside_room.GetComponent<AudioSource>().Play();
            Invoke("moveToTheRoom", 1f);
            
            target_enter = true;
        }
    }

    private void moveToTheRoom()
    {
        player_outside.transform.position = new Vector3(-6.027725f, 4.41f, 14.53985f);
    }

}
