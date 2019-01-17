using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {

    public AudioSource _audioSource;
    

	// Use this for initialization
	void Start () {
        _audioSource = this.gameObject.GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void doorOpen()
    {
        _audioSource.Play();
        while (this.gameObject.transform.position.z >-1) this.gameObject.transform.position -= new Vector3(0,0, 0.1f);
    }
}
