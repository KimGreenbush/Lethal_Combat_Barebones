using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Player Stats")]
    public int Strength;
    public int Dexterity;
    public int Health;

    [SerializeField]
    public GameObject healthFill;

    private Vector2 healthScale;
    private Transform healthTransform;

    public void Start() {
        healthTransform = healthFill.GetComponent<RectTransform>();
        healthScale = healthFill.transform.localScale;
        

    }

    public void Attack(GameObject weapon, GameObject target) {
        

        //Debug.Log (target.name);
        int number = weapon.GetComponent<Weapon_Script>().BaseMod;
        //Debug.Log(number);
        //this.GetComponent<Animator>().Play("melee");
        target.GetComponent<Player_Script>().TakeDamage(5);


    }

    public void TakeDamage(int damage) {
       // Debug.Log("Damage!");
        this.CheckDodged();
        this.Health -= damage;
       // Debug.Log($"dmage percent: {Health/100f}");
        this.GetComponent<Animator>().Play("damage");
        this.healthFill.transform.localScale = new Vector2 ((healthScale.x * (Health/100f) ) ,healthScale.y);
        this.CheckIfDead();
    }

    public bool CheckIfDead() {
        return Health <= 0;
    }

    public void CheckDodged() {

    }
}
