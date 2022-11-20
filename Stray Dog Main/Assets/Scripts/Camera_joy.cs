using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_joy : MonoBehaviour
{
    //public Vector3 mousepos;
    public FixedJoystick look_joy;
    public Vector3 mover;
    float speed = 200f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(look_joy.Horizontal != 0)
        {
        //transform.Rotate(Vector3.up, look_joy.Horizontal * speed);
        //transform.Rotate(Vector3.left, look_joy.Vertical * speed);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.eulerAngles.x, look_joy.Horizontal * speed, transform.rotation.eulerAngles.z), 5f); 
        }
    }
}
