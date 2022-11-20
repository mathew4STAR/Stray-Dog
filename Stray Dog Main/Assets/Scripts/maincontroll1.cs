using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincontroll1 : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject bg;
    public GameObject nxt;
    public GameObject player;
    public check_movement cm;
    public GameObject cameraaa;
    public eye_contact ec;
    float timer;
    float step = 0;
    // Start is called before the first frame update
    void Start()
    {
        cm = player.GetComponent<check_movement>();
        ec = cameraaa.GetComponent<eye_contact>();
    }

    // Update is called once per frame
    void Update()
    {
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
        }
        if(step == 3)
        {
            two.SetActive(false);
            nxt.SetActive(false);
            bg.SetActive(false);
            cm.go = true;
            step++;
            timer = Time.time;

        }
        if(Time.time - timer >= 6 && step == 4)
        {
            //Debug.Log("test");
            step++;
        }
        if(step == 5)
        {
            cm.go = false;
            //Debug.Log("test2");
            three.SetActive(true);
            nxt.SetActive(true);
            bg.SetActive(true);

        }
        if(step == 6)
        {
            three.SetActive(false);
            nxt.SetActive(false);
            bg.SetActive(false);
            ec.go = true;
        }
        //Debug.Log(step);
    }
    public void next()
    {
        step++;
    }
}
