using UnityEngine;
using System.Collections;

public class EditorMouseLook : MonoBehaviour {
    // Mouse inputs
    private float mouseX, mouseY, mouseZ = 0;

    void Start() {
        // Set MouseX, Y, and Z values to current Camera's rotation
        mouseX = transform.rotation.eulerAngles.y;
        mouseY = transform.rotation.eulerAngles.x;
        mouseZ = transform.rotation.eulerAngles.z;
    }

    // Update is called once per frame
    void Update() {
        // If the ALT button is pressed, rotate head
            // Get mouse X input
       
            Debug.Log("Mouse Pos: " + mouseX + ", " + mouseY);
           
            mouseX += Input.GetAxis("Mouse X") * 5;
            mouseY -= Input.GetAxis("Mouse Y") * 2.4f;

            if (Input.touchCount > 0)
            {
                mouseX = Input.touches[0].position.x;
                mouseY = Input.touches[0].position.y;
            }
            // Keep mouseX value between 0 and 360

            if (mouseX <= 0)
            {
                mouseX = 0;
            }
            else if (mouseX >= 180)
            {
                mouseX = 180;
            }
            // Get mouse Y input



            // Keep mouseY value between 0 and 360
            if (mouseY <= -20)
            {
                mouseY = -20;
            }
            else if (mouseY >= 20)
            {
                mouseY = 20;
            }
        

        // Set the rotation of the VR Main Camera
        transform.rotation = Quaternion.Euler(mouseY, mouseX, mouseZ);
    }
}