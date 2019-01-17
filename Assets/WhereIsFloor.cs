using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhereIsFloor : MonoBehaviour {

    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("What " +this.name +  " hit is : "+collision.collider.name);
    }
}
