using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samplePuzzle1 : MonoBehaviour {

    public GameObject relatedObject;
    public GameObject door;
    public bool target_enter = false;
    private AudioSource _audioSource;

    // Use this for initialization
    void Start () {
        _audioSource = this.gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (!target_enter&&collision.gameObject.name == relatedObject.name)
        {
            target_enter = true;
            _audioSource.PlayOneShot(_audioSource.clip, 1.0f);
            door.GetComponent<door>().doorOpen();
        }
    }
}
