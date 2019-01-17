using UnityEngine;
using Valve.VR.InteractionSystem;

public class room3Open : MonoBehaviour
{

    public GameObject door;
    public GameObject passwordtext;
    private puzzle_password enterbutton;
    private AudioSource _audioSource;
    private bool audio_played = false;

    // Use this for initialization
    void Start()
    {
        enterbutton = passwordtext.GetComponent<puzzle_password>();
        _audioSource = door.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audio_played&&enterbutton.isRightPassword)
        {
            _audioSource.Play();
            door.transform.GetChild(0).gameObject.SetActive(false);
            door.transform.GetChild(1).gameObject.SetActive(true);
            door.transform.GetChild(2).gameObject.SetActive(true);
            audio_played = true;
        }
    }
}
