using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reachambulance : MonoBehaviour
{
    public GameObject canva;
    public maincontroll3 mc3;
    // Start is called before the first frame update
    void Start()
    {
        mc3 = canva.GetComponent<maincontroll3>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        mc3.step++;
        Debug.Log("ha;klsjf");
        //temp
        //SceneManager.LoadScene("win");
    }
}
