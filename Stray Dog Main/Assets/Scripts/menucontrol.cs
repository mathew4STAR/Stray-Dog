using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontrol : MonoBehaviour
{
    public GameObject levels;
    public GameObject about;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    public void Play()
    {
        Back();
        levels.SetActive(true);
    }
    */
    public void Play()
    {
        SceneManager.LoadScene("levels");
        Debug.Log("test");
    }
    public void Back()
    {
        levels.SetActive(false);
        about.SetActive(false);

    }
    public void SS()
    {
        Application.OpenURL("https://emmanuelthomasindi.wixsite.com/dost/team");
    }
    public void Website()
    {
        Application.OpenURL("https://emmanuelthomasindi.wixsite.com/dost/shop-1");
    }
    public void About()
    {
        Back();
        about.SetActive(true);

    }
}
