using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public GameObject Weapon;

    [SerializeField]
    public GameObject Player;

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(() => Player.GetComponent<Fighter_Script>().Attack(Weapon));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
