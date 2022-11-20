using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog_out : MonoBehaviour
{
    Vector3 endpos = new Vector3(85.6f, 3.95f, 37.4f);
    float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position ,endpos, speed * Time.deltaTime);
    }
}
