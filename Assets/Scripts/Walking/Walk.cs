using System.Collections;
using UnityEngine;

namespace Assets.TutorialInfo.Scripts
{
    public class Walk : MonoBehaviour
    {
        private Animator _animator;
        private bool _isWalking;
        private  Animator _anim;

        // Use this for initialization
        void Start()
        {
            _animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;


            transform.Rotate(0, x, 0);

            if (Input.GetKey(KeyCode.W))
            {
                if (!_isWalking)
                {
                    _isWalking = true;
                    _anim.Play("Walk");
                }

                var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
                transform.Rotate(0, 0, z); // Só se movimenta quando "W" for apertado
            }
            else
            {
                if( _isWalking )
                {
                    _anim.Play("Grounded", -1);
                }
                _isWalking = false;
            }
        }
    }
}