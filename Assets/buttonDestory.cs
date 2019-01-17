using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    public class buttonDestory : MonoBehaviour
    {
        public GameObject zhaozi;
        public GameObject zhong;
        public GameObject boli;
        public HoverButton hoverButton;
        // Use this for initialization
        void Start()
        {
            hoverButton.onButtonDown.AddListener(OnButtonDown);
            Physics.IgnoreCollision(zhaozi.GetComponent<Collider>(), zhong.GetComponent<Collider>());
        }

        private void OnButtonDown(Hand hand)
        {
            zhaozi.SetActive(false);
            boli.SetActive(false);
        }
    }
}
