using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToStart : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    private Camera cam;
    public float speed = 5.0f;
    public float DestFov = 40.0f;
    public float fov;
    private int count;
    public Canvas c;
    // Use this for initialization
    void Start () {
        //offset.x = 0;
        //offset.y = 0;
        //offset.z = 50;
        fov = 8.0f;
        count = 0;
       //StartCoroutine(WaitTimer());
    }
    IEnumerator WaitTimer()
    {
        print(Time.time);
        yield return new WaitForSecondsRealtime(100);
        print(Time.time);
    }
    // Update is called once per frame
    void Update () {
        
        count++;
            if (count > 500)
        {
            c.enabled = false ;
            //fov = Mathf.MoveTowards(fov, DestFov, Time.deltaTime * speed);
            //Camera.current.fieldOfView = fov;
        }

        //if (transform.position.z < -200)
        //transform.position += offset;
    }
}
