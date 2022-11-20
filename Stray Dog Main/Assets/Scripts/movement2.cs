using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    public FixedJoystick joy;
    float speed = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveto = new Vector3(-joy.Vertical * speed, 0, joy.Horizontal * speed);
        transform.Translate(moveto);
    }
}
