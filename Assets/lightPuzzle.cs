using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightPuzzle : MonoBehaviour {

    public GameObject door;
    public GameObject[] dipan;

    private AudioSource _audioSource;
    // Use this for initialization
    void Start () {
        _audioSource = door.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void OpenDoor()
    {
        Debug.Log("puzzle 2 solved!");
        _audioSource.Play();
        door.transform.GetChild(0).gameObject.SetActive(false);
        door.transform.GetChild(1).gameObject.SetActive(true);
        door.transform.GetChild(2).gameObject.SetActive(true);
        for (int i = 0; i < dipan.Length; i++) dipan[i].SetActive(true);
    }
}
