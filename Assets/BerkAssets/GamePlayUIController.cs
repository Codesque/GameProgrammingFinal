using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayUIController : MonoBehaviour
{

    bool isActivated = false;
    Canvas pauseCanvas;


    // Start is called before the first frame update
    void Start()
    {
        pauseCanvas = transform.parent.GetChild(1).GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Escape") != 0 && !isActivated) { 
            isActivated = true;
            pauseCanvas.enabled = !pauseCanvas.enabled;
            if(pauseCanvas.enabled) Time.timeScale = 0.00825f; 
            else Time.timeScale = 1f;
        
        }


        if(Input.GetAxis("Escape") == 0)
            isActivated = false;

    }
}
