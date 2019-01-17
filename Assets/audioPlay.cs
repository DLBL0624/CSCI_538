using UnityEngine;

public class audioPlay : MonoBehaviour {

    public AudioSource _audioSource;
    public Vector3 curPos, lastPos;

    // Use this for initialization
    void Start () {
        lastPos = this.gameObject.transform.position;
        _audioSource = this.gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        curPos = this.gameObject.transform.position;
        if (curPos!=lastPos&&!_audioSource.isPlaying)
        {
            _audioSource.PlayOneShot(_audioSource.clip,1.0f);
            
        }
        else if(curPos==lastPos)
        {
            _audioSource.Stop();
        }
        lastPos = curPos;

	}

}
