using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class maincontroll2 : MonoBehaviour
{
    public Animator arms;
    public GameObject arm;
    public GameObject dog;
    public GameObject dog_p;
    public dog_out dg;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject bg;
    public GameObject nxt;
    public GameObject player;
    public GameObject four;
    public NavMeshAgent nm;
    float timer;
    float timerr;
    public float step = 0;
    public AudioSource ad;

    // Start is called before the first frame update
    void Start()
    {
        dg = dog.GetComponent<dog_out>();
        nm = dog_p.GetComponent<NavMeshAgent>();
        ad = GetComponent<AudioSource>();
        arms = arm.GetComponent<Animator>();
        nm.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(step);
        if(step == 1)
        {
            one.SetActive(false);
            nxt.SetActive(false);
            bg.SetActive(false);
            step++;

        }
        if(step == 2)
        {
            two.SetActive(true);
            nxt.SetActive(true);
            bg.SetActive(true);
            timer = Time.time;

        }
        if(step == 3)
        {
            two.SetActive(false);
            nxt.SetActive(false);
            bg.SetActive(false);
            timer = Time.time;
            step++;
            nm.Resume();
        }
        if(step == 4 && Time.time - timer > 10)
        {
            nm.Stop();
            three.SetActive(true);
            nxt.SetActive(true);
            bg.SetActive(true);
        }
        if(step == 5)
        {
            three.SetActive(false);
            nxt.SetActive(false);
            bg.SetActive(false);
        }
        if(step == 6)
        {
            four.SetActive(true);
            nxt.SetActive(true);
            bg.SetActive(true);

        }
        if(step == 7)
        {
            nm.Resume();
            four.SetActive(false);
            nxt.SetActive(false);
            bg.SetActive(false);
        }
        if(step == 10)
        {
            dg.enabled = true;
        }


        
    }
    public void next()
    {
        step++;
    }
    public void yell()
    {
        ad.Play();
        step++;
    }
    public void punch()
    {   
        step++;
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(), speed * Time.deltaTime);
    }

}
