using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menurotate : MonoBehaviour
{
    float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y = transform.rotation.eulerAngles.y; 
        y = y + 0.05f;

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, y, transform.eulerAngles.z);
    }
}
