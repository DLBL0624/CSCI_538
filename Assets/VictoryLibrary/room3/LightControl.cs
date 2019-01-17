using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public GameObject[] lights;
    public GameObject ButtonGroup;
    public GameObject OpenDoor;
    public Material[] Mats;
    public Material[] buttonMats;
    private lightPuzzle LightPuzzleScript;
    private int[] CurrentStatus;
    public bool target_enter = false;
    // Use this for initialization
    void Start()
    {
        CurrentStatus = new int[4];
        LightPuzzleScript = OpenDoor.GetComponent<lightPuzzle>();
        for (int i = 0; i < 4; i++)
        {
            CurrentStatus[i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            lights[0].SetActive(!lights[0].activeSelf);
            lights[3].SetActive(!lights[3].activeSelf);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            lights[0].SetActive(!lights[0].activeSelf);
            lights[1].SetActive(!lights[1].activeSelf);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            lights[1].SetActive(!lights[1].activeSelf);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            lights[0].SetActive(!lights[0].activeSelf);
            lights[2].SetActive(!lights[2].activeSelf);
        }
    }

    public void OnButtonPressed(int keyCode)
    {
        if (!checkAllCleared())
        {
            switch (keyCode)
            {
                case 1:
                    {
                        CurrentStatus[0] = (CurrentStatus[0] + 1) % 2;
                        CurrentStatus[3] = (CurrentStatus[3] + 1) % 2;
                        lights[0].GetComponent<MeshRenderer>().material = Mats[CurrentStatus[0]];
                        lights[3].GetComponent<MeshRenderer>().material = Mats[CurrentStatus[3]];
                        ButtonGroup.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(2).gameObject.SetActive(false);
                        ButtonGroup.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(true);
                        ButtonGroup.transform.GetChild(3).GetChild(2).GetComponent<MeshRenderer>().material = buttonMats[1];
                        ButtonGroup.transform.GetChild(3).GetChild(3).GetComponent<MeshRenderer>().material = buttonMats[1];

                        // lights[0].SetActive(!lights[0].activeSelf);
                        // lights[3].SetActive(!lights[3].activeSelf);
                    }
                    break;

                case 2:
                    {
                        CurrentStatus[0] = (CurrentStatus[0] + 1) % 2;
                        CurrentStatus[1] = (CurrentStatus[1] + 1) % 2;
                        lights[0].GetComponent<MeshRenderer>().material = Mats[CurrentStatus[0]];
                        lights[1].GetComponent<MeshRenderer>().material = Mats[CurrentStatus[1]];
                        ButtonGroup.transform.GetChild(2).GetChild(0).GetChild(0).GetChild(2).gameObject.SetActive(false);
                        ButtonGroup.transform.GetChild(2).GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(true);
                        ButtonGroup.transform.GetChild(2).GetChild(2).GetComponent<MeshRenderer>().material = buttonMats[1];
                        ButtonGroup.transform.GetChild(2).GetChild(3).GetComponent<MeshRenderer>().material = buttonMats[1];
                        // lights[0].SetActive(!lights[0].activeSelf);
                        // lights[1].SetActive(!lights[1].activeSelf);
                    }
                    break;
                case 3:
                    {
                        CurrentStatus[1] = (CurrentStatus[1] + 1) % 2;
                        lights[1].GetComponent<MeshRenderer>().material = Mats[CurrentStatus[1]];
                        ButtonGroup.transform.GetChild(1).GetChild(0).GetChild(0).GetChild(2).gameObject.SetActive(false);
                        ButtonGroup.transform.GetChild(1).GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(true);
                        ButtonGroup.transform.GetChild(1).GetChild(2).GetComponent<MeshRenderer>().material = buttonMats[1];
                        ButtonGroup.transform.GetChild(1).GetChild(3).GetComponent<MeshRenderer>().material = buttonMats[1];
                        // lights[1].SetActive(!lights[1].activeSelf);
                    }
                    break;
                case 4:
                    {
                        CurrentStatus[0] = (CurrentStatus[0] + 1) % 2;
                        CurrentStatus[2] = (CurrentStatus[2] + 1) % 2;
                        lights[0].GetComponent<MeshRenderer>().material = Mats[CurrentStatus[0]];
                        lights[2].GetComponent<MeshRenderer>().material = Mats[CurrentStatus[2]];
                        ButtonGroup.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(2).gameObject.SetActive(false);
                        ButtonGroup.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(true);
                        ButtonGroup.transform.GetChild(0).GetChild(2).GetComponent<MeshRenderer>().material = buttonMats[1];
                        ButtonGroup.transform.GetChild(0).GetChild(3).GetComponent<MeshRenderer>().material = buttonMats[1];
                        // lights[0].SetActive(!lights[0].activeSelf);
                        // lights[2].SetActive(!lights[2].activeSelf);
                    }
                    break;
                default:
                    break;
            }
            if (checkAllCleared())
            {
                LightPuzzleScript.OpenDoor();
            }
        }
       
    }


    public void OnButtonReleased(int keyCode)
    {
        if(!checkAllCleared())
        {
            switch (keyCode)
            {
                case 1:
                    {
                        ButtonGroup.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(2).gameObject.SetActive(true);
                        ButtonGroup.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(false);
                        ButtonGroup.transform.GetChild(3).GetChild(2).GetComponent<MeshRenderer>().material = buttonMats[0];
                        ButtonGroup.transform.GetChild(3).GetChild(3).GetComponent<MeshRenderer>().material = buttonMats[0];
                    }
                    break;

                case 2:
                    {
                        ButtonGroup.transform.GetChild(2).GetChild(0).GetChild(0).GetChild(2).gameObject.SetActive(true);
                        ButtonGroup.transform.GetChild(2).GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(false);
                        ButtonGroup.transform.GetChild(2).GetChild(2).GetComponent<MeshRenderer>().material = buttonMats[0];
                        ButtonGroup.transform.GetChild(2).GetChild(3).GetComponent<MeshRenderer>().material = buttonMats[0];
                    }
                    break;
                case 3:
                    {
                        ButtonGroup.transform.GetChild(1).GetChild(0).GetChild(0).GetChild(2).gameObject.SetActive(true);
                        ButtonGroup.transform.GetChild(1).GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(false);
                        ButtonGroup.transform.GetChild(1).GetChild(2).GetComponent<MeshRenderer>().material = buttonMats[0];
                        ButtonGroup.transform.GetChild(1).GetChild(3).GetComponent<MeshRenderer>().material = buttonMats[0];
                    }
                    break;
                case 4:
                    {
                        ButtonGroup.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(2).gameObject.SetActive(true);
                        ButtonGroup.transform.GetChild(0).GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(false);
                        ButtonGroup.transform.GetChild(0).GetChild(2).GetComponent<MeshRenderer>().material = buttonMats[0];
                        ButtonGroup.transform.GetChild(0).GetChild(3).GetComponent<MeshRenderer>().material = buttonMats[0];
                    }
                    break;
                default:
                    break;
            }
        }
        else
        {
                for (int i = 0; i < 4; i++)
                {
                    ButtonGroup.transform.GetChild(i).GetChild(0).GetChild(0).GetChild(2).gameObject.SetActive(false);
                    ButtonGroup.transform.GetChild(i).GetChild(0).GetChild(0).GetChild(1).gameObject.SetActive(true);
                    ButtonGroup.transform.GetChild(i).GetChild(2).GetComponent<MeshRenderer>().material = buttonMats[1];
                    ButtonGroup.transform.GetChild(i).GetChild(3).GetComponent<MeshRenderer>().material = buttonMats[1];
                }   
        }
    }

    bool checkAllCleared()
    {
        bool bAllCleared = false;
        if (CurrentStatus[0] + CurrentStatus[1] + CurrentStatus[2] + CurrentStatus[3] == 4)
        {
            bAllCleared = true;
        }

        return bAllCleared;
    }

}
