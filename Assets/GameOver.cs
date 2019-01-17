using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public GameObject button_scan;
    public Material[] buttonMats;
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
            button_scan.GetComponent<AudioSource>().Play();
            Invoke("ExitGame", 1f);

            target_enter = true;
        }
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
