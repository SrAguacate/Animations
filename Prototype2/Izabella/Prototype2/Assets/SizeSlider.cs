using UnityEngine;

namespace NewtonVR
{
    public class SizeSlider : MonoBehaviour
    {

        public Transform From;

        public Renderer Result;

        public NVRSlider Slider;

        private void Update()
        {
            Result.transform.localScale += new Vector3(Result.transform.localScale.x, Result.transform.localScale.y, Result.transform.localScale.z + Slider.CurrentValue);
        }
    }
}
