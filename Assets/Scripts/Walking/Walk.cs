using System.Collections;
using UnityEngine;

namespace Assets.TutorialInfo.Scripts
{
    public class Walk : MonoBehaviour
    {
        private bool _isWalking;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            try
            { 
                var translation = Input.GetAxis("Vertical") * 5.0f * Time.deltaTime;
                var strafe = Input.GetAxis("Horizontal") * 5.0f * Time.deltaTime;

                transform.Translate(strafe, 0, translation);
            }
            catch (System.Exception ex)
            {
                Debug.LogError(ex.Message);
            }
        }
    }
}