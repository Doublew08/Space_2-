using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeManager : MonoBehaviour
{
    public static FadeManager instance;
    public Image fadeImage;
    public Color sColor;
    public Color eColor;
    public float duration;
    public bool isFading;
    public int SceneIndexToFadeTo;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        FadeIn();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FadeIn()
    {
        StartCoroutine(beginFade());
    }
    public void FadeOutToScene(int sceneIndex)
    {
        StartCoroutine(FadeOut(sceneIndex));
    }
    
    IEnumerator FadeOut(int sceneIndex)
    {
        isFading = true;
        float timer = 0f;
        while (timer <= duration)
        {
            fadeImage.color = Color.Lerp(sColor, eColor, timer / duration);
            timer += Time.deltaTime;
            yield return null;
        }
        isFading = false;
        SceneManager.LoadScene(sceneIndex);
    }
    IEnumerator beginFade()
    {
        isFading = true;
        float timer = 0f;
        while (timer <= duration)
        {
            fadeImage.color = Color.Lerp(sColor, eColor, timer/duration);
            timer += Time.deltaTime;
            yield return null;
        }
        isFading = false;
        //SceneManager.LoadScene(sceneIndex);
    }
   
}
