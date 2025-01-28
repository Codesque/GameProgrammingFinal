using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject creditsPanel;
    public IEnumerator StartGameCoroutine()
        {
            yield return new WaitForSeconds(2f);
            AsyncOperation op =  SceneManager.LoadSceneAsync("GamePlay");
            while (!op.isDone) { yield return null; }
        }
    public void StartGame()
    {
        StartCoroutine(StartGameCoroutine());
    }
    public void QuitGame()
        {
            Debug.Log("Çıkış yapılıyor");
            Application.Quit();
        }
    public void SettingsPanelController()
    {
        bool isActive = settingsPanel.activeSelf;
        settingsPanel.SetActive(!isActive);

    }
    public void CreditsPanelController()
    {
        bool isActive = creditsPanel.activeSelf;
        creditsPanel.SetActive(!isActive);
    }
    
    
}
