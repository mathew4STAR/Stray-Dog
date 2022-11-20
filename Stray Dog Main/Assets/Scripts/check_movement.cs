using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class check_movement : MonoBehaviour
{
    Vector3 prev;
    public bool go = false;
    public GameObject dog;
    bool done = false;
    AudioSource bark;
    int inc = 0;
    // Start is called before the first frame update
    void Start()
    {
        prev = transform.position; 
        bark = dog.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(prev != transform.position && go == true)
        {
            //Debug.Log("test");
            if(done == false)
            {
                bark.Play();
                done = true;
            }
            
            inc++;
        }
        if(inc > 900)
        {
            SceneManager.LoadScene("end");
        }
        prev = transform.position;
        //Debug.Log(inc);
    }
}
