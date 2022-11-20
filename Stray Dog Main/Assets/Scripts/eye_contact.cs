using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eye_contact : MonoBehaviour
{
    public float seldis = 5f;
    public bool go = false;
    public GameObject dog;
    public AudioSource bark;
    bool done = false;
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        bark = dog.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(go==true)
        {
            Ray interationRay = new Ray(transform.position, transform.forward);
            RaycastHit interationRayHit;
            bool hitfound = Physics.Raycast(interationRay, out interationRayHit, seldis);
            if(hitfound)
            {
                GameObject Ihit = interationRayHit.transform.gameObject;
                Debug.Log(Ihit.name);
                if(Ihit.name == "dog2")
                {
                    counter++;
                    if(done == false)
                    {
                        bark.Play();
                        done = true;
                    }

                }
            }
        }
        if(counter > 1000)
        {
            SceneManager.LoadScene("end");
        }
        Debug.Log(counter);
    }
}
