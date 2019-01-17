using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle4 : MonoBehaviour {

    public GameObject bell;
    public GameObject puzzle4_obj;
    public GameObject zhong_light;
    public GameObject player;
    private const string passText = "4231";
    private string recentText = "";
    public Material[] mat_color;
    private bool finish = false;
    private bool wrong = false;
    private AudioSource _audioSource,_audioSource_1;
    public GameObject _can;

	// Use this for initialization
	void Start () {
        _audioSource = puzzle4_obj.GetComponent<AudioSource>();
        _audioSource_1 = bell.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (wrong)
        {
            WrongOrder();
            Invoke("restore", 0.5f);
            Invoke("WrongOrder", 1.0f);
            wrong = false;
        }
        if (recentText.Length == passText.Length&&bell.transform.GetChild(1).position.y<6.5)
        {
            bell.transform.GetChild(1).position += new Vector3(0, 0.001f, 0);
            bell.transform.GetChild(1).Rotate(new Vector3(0, 0.06f, 0));
        }
        
    }

    private void endGame()
    {
        //player.transform.position = new Vector3(-13.778f, 4.41f, 13.5f);
    }

    public void OnButtonPressed(int keyCode)
    {
        if(!finish)
        { 
            switch (keyCode)
            {
                case 1:
                    {
                        recentText += '1';
                        puzzle4_obj.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[2];
                        puzzle4_obj.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(1).GetChild(0).GetComponent<AudioSource>().Play();
                    }
                    break;

                case 2:
                    {
                        recentText += '2';
                        puzzle4_obj.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[1];
                        puzzle4_obj.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(1).GetChild(0).GetComponent<AudioSource>().Play();

                    }
                    break;
                case 3:
                    {
                        recentText += '3';
                        puzzle4_obj.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[3];
                        puzzle4_obj.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(1).GetChild(0).GetComponent<AudioSource>().Play();
                    }
                    break;
                case 4:
                    {
                        recentText += '4';
                        puzzle4_obj.transform.GetChild(0).GetChild(3).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[0];
                        puzzle4_obj.transform.GetChild(0).GetChild(3).GetChild(0).GetChild(1).GetChild(0).GetComponent<AudioSource>().Play();
                    }
                    break;
                default:
                    break;
            }

            if (!finish && recentText.Length == passText.Length)
            {
                if (recentText == passText)
                {
                    _audioSource_1.Play();
                    //bell.transform.position += new Vector3(0, 1.5f,0);
                    RightOrder();
                    zhong_light.SetActive(true);
                    finish = true;
                    Invoke("endGame", 45f);
                }
                else
                {
                    _audioSource.Play();
                    wrong = true;
                    recentText = "";
                }
            }

        }
        
    }
    void WrongOrder()
    {
        puzzle4_obj.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[4];
        puzzle4_obj.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[4];
        puzzle4_obj.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[4];
        puzzle4_obj.transform.GetChild(0).GetChild(3).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[4];
    }
    void restore()
    {
        puzzle4_obj.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[2];
        puzzle4_obj.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[1];
        puzzle4_obj.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[3];
        puzzle4_obj.transform.GetChild(0).GetChild(3).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[0];
    }
    void RightOrder()
    {
        puzzle4_obj.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[5];
        puzzle4_obj.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[5];
        puzzle4_obj.transform.GetChild(0).GetChild(2).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[5];
        puzzle4_obj.transform.GetChild(0).GetChild(3).GetChild(0).GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material = mat_color[5];
    }
}
