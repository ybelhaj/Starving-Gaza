using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If esc is pressed quit the application
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Esc pressed");
            Application.Quit();
        }
    }
}
