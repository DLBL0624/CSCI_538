using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
    public class clearButton : MonoBehaviour
    {
        public HoverButton hoverButton;
        public GameObject prefab;

        private TextMeshPro textMesh;

        private void HandHoverUpdate(Hand hand)
        {
            textMesh = prefab.GetComponent<TextMeshPro>();
            textMesh.SetText("");
            Debug.Log("clear:" + textMesh.text);
        }
    }
}