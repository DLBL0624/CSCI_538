using UnityEngine;

public class aishangmeiyou : MonoBehaviour {
    public GameObject puzzle3;
    public GameObject puzzle4;
    public GameObject dipan1;
    public GameObject dipan2;
    public GameObject dipan3;

    private AudioSource _audioSource;
    private AudioClip _audioClip;
    aishang ais1,ais2,ais3;
    private bool finish = false;
	// Use this for initialization
	void Start () {
        ais1 = dipan1.GetComponent<aishang>();
        ais2 = dipan2.GetComponent<aishang>();
        ais3 = dipan3.GetComponent<aishang>();
        _audioSource = puzzle3.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!finish&&ais1.target_enter&& ais2.target_enter && ais3.target_enter)
        {
            puzzle4.transform.GetChild(0).gameObject.SetActive(true);
            _audioSource.Play();
            dipan1.SetActive(false);
            dipan2.SetActive(false);
            dipan3.SetActive(false);
            finish = true;
        }
	}
}
