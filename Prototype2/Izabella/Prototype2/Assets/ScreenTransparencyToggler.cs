using UnityEngine;

namespace NewtonVR
{
    public class ScreenTransparencyToggler : MonoBehaviour
    {

        public NVRButton Button;

        public GameObject screen;

        private void Update()
        {
            if (Button.ButtonDown)
            {
                screen.GetComponent<Renderer>().enabled = false;
            }
        }
    }
}
