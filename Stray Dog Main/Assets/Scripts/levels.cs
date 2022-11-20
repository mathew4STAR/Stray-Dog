using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void l1()
    {
        SceneManager.LoadScene("one");
    }
    public void l2()
    {
        SceneManager.LoadScene("two");
    }
    public void l3()
    {
        SceneManager.LoadScene("three");
    }
}
