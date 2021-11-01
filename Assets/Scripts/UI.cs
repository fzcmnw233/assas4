using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;



public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void LoadFirstLevel()
    {
        SceneManager.LoadScene("Level1Scene");

    }


    public void Quit()
    {
        SceneManager.LoadScene("StartScene");
    }

}
