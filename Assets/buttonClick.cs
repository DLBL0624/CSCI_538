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
    public class buttonClick : MonoBehaviour
    {
        public HoverButton hoverButton;
        public GameObject prefab;

        private TextMeshPro textMesh;

        private void HandHoverUpdate(Hand hand)
        {
            textMesh = prefab.GetComponent<TextMeshPro>();
            string str = textMesh.text;
            int n = str.Length;
            if(n == 0 || str[n-1]!=this.name[0])
            {
                str += this.name[0];
                if (n > 2) str = str.Substring(1);
                textMesh.SetText(str);
            }
            //Debug.Log(textMesh.text);
            //Console.WriteLine(textMesh.GetParsedText());
        }
    }
}