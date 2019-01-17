using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LightControls = LightControl;

public class MouseRayCast : MonoBehaviour {
    private LightControl buttonCtrl;
	// Use this for initialization
	void Start () {
        buttonCtrl = GameObject.Find("ButtonGroup").GetComponent<LightControl>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        { 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPos;
            Physics.Raycast(ray, out hitPos);

            if (hitPos.collider.gameObject.tag == "LightSwitch")
            {
                int buttonIndex = int.Parse(hitPos.collider.gameObject.name.Replace("Button", string.Empty));
                buttonCtrl.OnButtonPressed(buttonIndex);
            }
        }
	}
}
