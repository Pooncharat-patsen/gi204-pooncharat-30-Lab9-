using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; 

    // Update 
    void Update()
    {
        // Vector3
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        
        movement = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0) * movement;

       
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}