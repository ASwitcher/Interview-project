using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestFind : MonoBehaviour
{
    public Text chestText;
    public int chestNbr;


    void Start()
    {
        chestNbr = 0;
    }

    
    void Update()
    {
        chestText.text = chestNbr.ToString();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Chest")
        {
            chestNbr++;
            Destroy(collision.gameObject);
        }
       




    }
}
