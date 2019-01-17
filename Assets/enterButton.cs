using UnityEngine;
using TMPro;

namespace Valve.VR.InteractionSystem
{
    public class enterButton : MonoBehaviour
    {
        public HoverButton hoverButton;
        public GameObject prefab;
        private const string rightPassword = "369";
        private TextMeshPro textMesh;
        public bool isRightPassword = false;

        private void HandHoverUpdate(Hand hand)
        {
            textMesh = prefab.GetComponent<TextMeshPro>();
            string str = textMesh.text;
            if (str==rightPassword)
            {
                isRightPassword = true;
                textMesh.color = Color.green;
            }
            Debug.Log(str);
        }
    }
}
