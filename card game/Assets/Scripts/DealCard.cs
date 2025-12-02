using UnityEngine;

public class DealCard : MonoBehaviour
{
    public GameObject[] dealtCard;
    public int cardGenerate;
    public GameObject hiButton;
    public GameObject loButton;
    public GameObject dealButton;
     public AudioSource dealCard;
    public void DealMyNewCard()
    {
        dealCard.Play();
        cardGenerate = Random.Range(2, 15);
        dealtCard[cardGenerate].SetActive(true);
        hiButton.SetActive(true);
        loButton.SetActive(true);
        dealButton.SetActive(false);
        CardControl.dealtCardNumber = cardGenerate;
    }
}