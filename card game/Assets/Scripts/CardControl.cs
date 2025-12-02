using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class CardControl : MonoBehaviour
{
    public static int dealtCardNumber;
    public static int newCardNumber;
    public GameObject correctText;
    public GameObject incorrectText;
    public static bool guessHi = false;
    public static bool guessLo = false;
    public GameObject hiButton;
    public GameObject loButton;
    public GameObject dealButton;
    public GameObject[] dealingLeftCards;
    public GameObject[] turningRightCards;
    public AudioSource cardDeal;
    public AudioSource correctCard;
    public AudioSource incorrectCard;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (guessHi == true)
        {
            cardDeal.Play();
            guessHi = false;
            hiButton.SetActive(false);
            loButton.SetActive(false);
            StartCoroutine(GuessingHigher());
        }
        if (guessLo == true)
        {
            cardDeal.Play();
            guessLo = false;
            hiButton.SetActive(false);
            loButton.SetActive(false);
            StartCoroutine(GuessingLower());
        }

        IEnumerator GuessingHigher()
        {
            yield return new WaitForSeconds(1);
            if (newCardNumber >= dealtCardNumber)
            {
                correctText.SetActive(true);
                correctCard.Play();
                GlobalScore.currentScore += 1; 
                yield return new WaitForSeconds(3);
                dealingLeftCards[2].SetActive(false);
                dealingLeftCards[3].SetActive(false);
                dealingLeftCards[4].SetActive(false);
                dealingLeftCards[5].SetActive(false);
                dealingLeftCards[6].SetActive(false);
                dealingLeftCards[7].SetActive(false);
                dealingLeftCards[8].SetActive(false);
                dealingLeftCards[9].SetActive(false);
                dealingLeftCards[10].SetActive(false);
                dealingLeftCards[11].SetActive(false);
                dealingLeftCards[12].SetActive(false);
                dealingLeftCards[13].SetActive(false);
                dealingLeftCards[14].SetActive(false);
                turningRightCards[2].SetActive(false);
                turningRightCards[3].SetActive(false);
                turningRightCards[4].SetActive(false);
                turningRightCards[5].SetActive(false);
                turningRightCards[6].SetActive(false);
                turningRightCards[7].SetActive(false);
                turningRightCards[8].SetActive(false);
                turningRightCards[9].SetActive(false);
                turningRightCards[10].SetActive(false);
                turningRightCards[11].SetActive(false);
                turningRightCards[12].SetActive(false);
                turningRightCards[13].SetActive(false);
                turningRightCards[14].SetActive(false);
                turningRightCards[newCardNumber].SetActive(true);
                yield return new WaitForSeconds(1);
                hiButton.SetActive(true);
                loButton.SetActive(true);
                dealtCardNumber = newCardNumber;
                correctText.SetActive(false);
            }
            else
            {
                incorrectText.SetActive(true);
                incorrectCard.Play();
                GlobalScore.currentScore = 0;
                yield return new WaitForSeconds(3);
                dealingLeftCards[2].SetActive(false);
                dealingLeftCards[3].SetActive(false);
                dealingLeftCards[4].SetActive(false);
                dealingLeftCards[5].SetActive(false);
                dealingLeftCards[6].SetActive(false);
                dealingLeftCards[7].SetActive(false);
                dealingLeftCards[8].SetActive(false);
                dealingLeftCards[9].SetActive(false);
                dealingLeftCards[10].SetActive(false);
                dealingLeftCards[11].SetActive(false);
                dealingLeftCards[12].SetActive(false);
                dealingLeftCards[13].SetActive(false);
                dealingLeftCards[14].SetActive(false);
                turningRightCards[2].SetActive(false);
                turningRightCards[3].SetActive(false);
                turningRightCards[4].SetActive(false);
                turningRightCards[5].SetActive(false);
                turningRightCards[6].SetActive(false);
                turningRightCards[7].SetActive(false);
                turningRightCards[8].SetActive(false);
                turningRightCards[9].SetActive(false);
                turningRightCards[10].SetActive(false);
                turningRightCards[11].SetActive(false);
                turningRightCards[12].SetActive(false);
                turningRightCards[13].SetActive(false);
                turningRightCards[14].SetActive(false);
                yield return new WaitForSeconds(1);
                dealButton.SetActive(true);
                incorrectText.SetActive(false);
            }
        }
        IEnumerator GuessingLower()
        {
            yield return new WaitForSeconds(1);
            if (newCardNumber <= dealtCardNumber)
            {
                correctText.SetActive(true);
                correctCard.Play();
                GlobalScore.currentScore += 1;
                yield return new WaitForSeconds(3);
                dealingLeftCards[2].SetActive(false);
                dealingLeftCards[3].SetActive(false);
                dealingLeftCards[4].SetActive(false);
                dealingLeftCards[5].SetActive(false);
                dealingLeftCards[6].SetActive(false);
                dealingLeftCards[7].SetActive(false);
                dealingLeftCards[8].SetActive(false);
                dealingLeftCards[9].SetActive(false);
                dealingLeftCards[10].SetActive(false);
                dealingLeftCards[11].SetActive(false);
                dealingLeftCards[12].SetActive(false);
                dealingLeftCards[13].SetActive(false);
                dealingLeftCards[14].SetActive(false);
                turningRightCards[2].SetActive(false);
                turningRightCards[3].SetActive(false);
                turningRightCards[4].SetActive(false);
                turningRightCards[5].SetActive(false);
                turningRightCards[6].SetActive(false);
                turningRightCards[7].SetActive(false);
                turningRightCards[8].SetActive(false);
                turningRightCards[9].SetActive(false);
                turningRightCards[10].SetActive(false);
                turningRightCards[11].SetActive(false);
                turningRightCards[12].SetActive(false);
                turningRightCards[13].SetActive(false);
                turningRightCards[14].SetActive(false);
                turningRightCards[newCardNumber].SetActive(true);
                yield return new WaitForSeconds(1);
                hiButton.SetActive(true);
                loButton.SetActive(true);
                dealtCardNumber = newCardNumber;
                correctText.SetActive(false);
            }
            else
            {
                incorrectText.SetActive(true);
                incorrectCard.Play();
                GlobalScore.currentScore = 0;
                yield return new WaitForSeconds(3);
                dealingLeftCards[2].SetActive(false);
                dealingLeftCards[3].SetActive(false);
                dealingLeftCards[4].SetActive(false);
                dealingLeftCards[5].SetActive(false);
                dealingLeftCards[6].SetActive(false);
                dealingLeftCards[7].SetActive(false);
                dealingLeftCards[8].SetActive(false);
                dealingLeftCards[9].SetActive(false);
                dealingLeftCards[10].SetActive(false);
                dealingLeftCards[11].SetActive(false);
                dealingLeftCards[12].SetActive(false);
                dealingLeftCards[13].SetActive(false);
                dealingLeftCards[14].SetActive(false);
                turningRightCards[2].SetActive(false);
                turningRightCards[3].SetActive(false);
                turningRightCards[4].SetActive(false);
                turningRightCards[5].SetActive(false);
                turningRightCards[6].SetActive(false);
                turningRightCards[7].SetActive(false);
                turningRightCards[8].SetActive(false);
                turningRightCards[9].SetActive(false);
                turningRightCards[10].SetActive(false);
                turningRightCards[11].SetActive(false);
                turningRightCards[12].SetActive(false);
                turningRightCards[13].SetActive(false);
                turningRightCards[14].SetActive(false);
                yield return new WaitForSeconds(1);
                dealButton.SetActive(true);
                incorrectText.SetActive(false);
            }
        }
    }
    

}


