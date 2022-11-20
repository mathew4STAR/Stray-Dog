using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour
{
    public GameObject pausemenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause()
    {
        pausemenu.SetActive(true);
    }
    public void Resume()
    {
        pausemenu.SetActive(false);
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
