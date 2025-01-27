using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsyncSahneGecis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    IEnumerator SceneLoadCoroutine() {

        //yield return new WaitForSeconds(0.5f);
        AsyncOperation operation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("GamePlay 1"); 
        while (!operation.isDone)
        {
            yield return null;

        }

    
    
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            StartCoroutine(SceneLoadCoroutine());
    }
}
