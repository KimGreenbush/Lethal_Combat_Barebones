using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter_Script : MonoBehaviour
{
    [SerializeField]
    public GameObject Player;
    [SerializeField]
    public GameObject PlayerMenu;

    [SerializeField]
    public GameObject Battle_Controller;



    [SerializeField]
    public GameObject Target;

    [SerializeField]
    public GameObject TargetMenu;



    
    public void Start(){
    }

    public void Attack(GameObject weapon){

        Player.GetComponent<Player_Script>().Attack(weapon,Target);
        Battle_Controller.GetComponent<Battle_Controller_Script>().NextTurn();
        
       // PlayerMenu.SetActive(false);

        // set next turn in battle controller
      //  Player.GetComponent<Player_Script>().healthFill.transform.localScale = new Vector2 ((healthScale.x * 0.75f ) ,healthScale.y);
        
    }

}
