using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class maincontroll3 : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject bg;
    public GameObject nxt;
    public GameObject player;
    public GameObject dog;
    public GameObject ambu;
    public GameObject four;
    public float timerr;
    public GameObject dest;
    float timer;
    public GameObject art;
    public float step = 0;
    public bool ambudone = false;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(step == 1)
        {
            one.SetActive(false);
            nxt.SetActive(false);
            bg.SetActive(false);
            dog.SetActive(true);
            timer = Time.time;
            step++;

        }
        if(step == 2 && Time.time - timer > 5)
        {
            two.SetActive(true);
            nxt.SetActive(true);
            bg.SetActive(true);

        }
        if(step == 3)
        {
            two.SetActive(false);
            nxt.SetActive(false);
            bg.SetActive(false);
            //timer = Time.time;
            step++;

        }
        //Debug.Log(Time.time);
        if(step == 4 && Time.time - timerr > 5 && ambudone == true)
        {
            three.SetActive(true);
            nxt.SetActive(true);
            bg.SetActive(true);
            dest.SetActive(true);
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
            four.SetActive(false);
            nxt.SetActive(false);
            bg.SetActive(false);
        }
        if(step == 8)
        {
            art.SetActive(true);
            nxt.SetActive(true);
        }
        if(step == 9)
        {
            SceneManager.LoadScene("win");
        }
        Debug.Log(step);
        
    }
    public void next()
    {
        step++;
    }
    public void Ambulance()
    {
        ambu.SetActive(true);
        timerr = Time.time;
        ambudone = true;
    }
    public void report()
    {
        step++;
    }
}
