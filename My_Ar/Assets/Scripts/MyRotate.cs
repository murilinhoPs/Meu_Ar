using UnityEngine;
using Lean;

namespace Lean.Touch
{

    public class MyRotate : MonoBehaviour
    {

        public Vector3 Axis = Vector3.down;


        private void OnEnable()
        {

        }

        private void OnDisable()
        {

        }

        // Update is called once per frame
        void Update()
        {
            var fingers = LeanTouch.Fingers;

            var touch = new LeanFinger();

            //transform.Rotate(Axis, touch.GetDegrees(fingers), Space.Self);

            Debug.Log("There are currently " + fingers.Count + " fingers touching the screen.");
        }
    }
}
