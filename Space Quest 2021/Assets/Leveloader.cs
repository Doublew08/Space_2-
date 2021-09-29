using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Leveloader : MonoBehaviour
{
    public Animator animator;
   

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Quest1").GetComponent<Quest>().MissionSucceeded)
        {
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }
    IEnumerator LoadLevel(int levelindex)
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(levelindex);


    }
}
