using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayButtonAnimation : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerClickHandler
{
    Animator animatorController;
    bool tiklandimi = false;
    bool mouseuzerindemi = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        tiklandimi = true;
        animatorController.SetBool("tiklandimi",tiklandimi);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouseuzerindemi = true;
        animatorController.SetBool("mouseuzerindemi",mouseuzerindemi);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        mouseuzerindemi = false;
        tiklandimi = false;
        animatorController.SetBool("mouseuzerindemi",mouseuzerindemi);
        animatorController.SetBool("tiklandimi",tiklandimi);
    }

    void Start()
    {
       animatorController = GetComponent<Animator>(); 
    }

    void Update()
    {
        
    }
}
