using UnityEngine;

namespace Assets.Scripts
{
    public class CameraMovement : MonoBehaviour
    {
        public float mouseSensitivity = 100.0f; // Futuramente será ajustável pelo player óbvio
        public Transform playerBody;
        private float xRotation = 0.0f;
        private float yRotation = 0.0f;

        // Use this for initialization
        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked; // Locka o cursor no centrda tela
        }

        // Update is called once per frame
        void Update()
        {
            // Pega o movimento do mouse (não faço idéia o motivo de multiplicar por Time.deltaTime) :)
            var mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; 
            var mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; 

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, 90.0f, -90.0f); // Limita o movimento da câmera

            yRotation -= mouseX;
            yRotation = Mathf.Clamp(yRotation, 90.0f, -90.0f);

            // Sepa que a mágica acontece aqui
            transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0.0f);
            playerBody.Rotate(mouseX * Vector3.up);
        }
    }
}