using UnityEngine;

public class aishang : MonoBehaviour {

    public GameObject relatedObject;
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
        if(collision.gameObject.name == relatedObject.name)
        {
            target_enter = true;
            _audioSource.PlayOneShot(_audioSource.clip,1.0f);
        }
    }

/*
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == relatedObject.name)
        {
            target_enter = true;
        }
    }
    */
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == relatedObject.name)
        {
            target_enter = false;
        }
    }
    /*
    bool getRed_enter()
    {
        return red_enter;
    }
    */
}
