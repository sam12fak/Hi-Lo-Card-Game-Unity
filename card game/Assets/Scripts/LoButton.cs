using UnityEngine;

public class LoButton : MonoBehaviour
{
  public GameObject[] dealtCard;
    public int cardGenerate;
   
    public void DealLoCard()
    {
        cardGenerate = Random.Range(2, 15);
        dealtCard[cardGenerate].SetActive(true);
    
        CardControl.newCardNumber = cardGenerate;
        CardControl.guessLo = true;
    }
}
