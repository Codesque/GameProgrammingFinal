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



    public IEnumerator GoMenuCoroutine() {

        AsyncOperation op = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(0);
        while (!op.isDone) { 
        
            yield return null;
        }
    
    
    }

    public void GoBackToMainMenu() { RoadGenerator.EnvironmentSpeed = 12f; CloseCanvas();StartCoroutine(GoMenuCoroutine()); }

    public void QuitGameFromMenu() { Application.Quit(); }

    public void CloseCanvas() { 
    
        pauseCanvas.enabled = false; 
        Time.timeScale = 1f;
    
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
