using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Valve.VR.InteractionSystem;

public class puzzle_password : MonoBehaviour {

    public GameObject monitor;
    TextMeshPro textMeshpro;
    private const string rightPassword = "249";
    public bool isRightPassword = false;
    AudioSource _audioSource;

    // Use this for initialization
    void Start () {
        textMeshpro = monitor.GetComponent<TextMeshPro>();
        _audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    public void OnButtonPressed(int keyCode)
    {
        string str = textMeshpro.text;
        
        int n = str.Length;
        switch(keyCode)
        {
            case 0:
                str += '0';
                textMeshpro.text = str;
                break;
            case 1:
                str += '1';
                textMeshpro.text = str;
                break;
            case 2:
                str += '2';
                textMeshpro.text = str;
                break;
            case 3:
                str += '3';
                textMeshpro.text = str;
                break;
            case 4:
                str += '4';
                textMeshpro.text = str;
                break;
            case 5:
                str += '5';
                textMeshpro.text = str;
                break;
            case 6:
                str += '6';
                textMeshpro.text = str;
                break;
            case 7:
                str += '7';
                textMeshpro.text = str;
                break;
            case 8:
                str += '8';
                textMeshpro.text = str;
                break;
            case 9:
                str += '9';
                textMeshpro.text = str;
                break;
            case 10:
                textMeshpro.SetText("");
                str = "";
                textMeshpro.text = "";
                break;
            case 11:
                Debug.Log(str==rightPassword);
                if (str == rightPassword)
                {
                    isRightPassword = true;
                    textMeshpro.SetText("");
                    str = "";
                    textMeshpro.text = "";
                    //textMeshpro.color = Color.green;
                }
                else
                {
                    _audioSource.Play();
                    textMeshpro.SetText("");
                    str = "";
                    textMeshpro.text = "";
                }
                break;
        }
        if (n > 2)
        {
            str = str.Substring(1);
            textMeshpro.text = str;
        }
        
        
        //Debug.Log(textMesh.text);
        //Console.WriteLine(textMesh.GetParsedText());
    }
}
