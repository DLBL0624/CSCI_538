using UnityEngine;
using Valve.VR.InteractionSystem;

public class room3open : MonoBehaviour
{

    public GameObject[] door;
    public GameObject passwordtext;
    private enterButton enterbutton;
    // Use this for initialization
    void Start()
    {
        enterbutton = passwordtext.GetComponent<enterButton>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enterbutton.isRightPassword)
        {
            for (int i = 0; i < door.Length; i++) door[i].SetActive(false);
        }
        else
        {
            // for (int i = 0; i < door.Length; i++) door[i].SetActive(true);
        }
    }
}
