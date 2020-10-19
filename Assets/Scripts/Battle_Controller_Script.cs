using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battle_Controller_Script : MonoBehaviour
{
    // Start is called before the first frame update
        [SerializeField]
        GameObject Player1Menu;

        [SerializeField]
        GameObject Player2Menu;

        bool P1Turn = false;
    void Start()
    {
        NextTurn();
    }

   
   public void ToggleTurn()
    {
        if(P1Turn){
            P1Turn = false;
        } else {
            P1Turn = true;
        }
    }


public void NextTurn() {
    ToggleTurn();
    if(P1Turn){
        Debug.Log("Player1 turn");
       Player2Menu.SetActive(false);
        Player1Menu.SetActive(true);
        
    } else {
        Debug.Log("Player2 turn");
       Player2Menu.SetActive(true);
       Player1Menu.SetActive(false);

    }

}
}