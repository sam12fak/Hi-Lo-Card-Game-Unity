using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public GameObject splashWhite;
    public GameObject splashText;
    public GameObject bgmStarter;

    void Start()
    {
        StartCoroutine(SplashStart());
    }

    IEnumerator SplashStart()
    {
        yield return new WaitForSeconds(4);
        bgmStarter.SetActive(true);
        yield return new WaitForSeconds(1);
        splashWhite.SetActive(false);
        splashText.SetActive(false);
    }
}
