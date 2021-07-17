using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 2f;
    Vector2 movement;
    public GameObject fishBtn;
    public ChestFind inv;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Fish")
        {
            fishBtn.SetActive(true);
        } 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Fish")
        fishBtn.SetActive(false);
    }

    public void fishButton()
    {
        fishBtn.SetActive(false);
        speed = 0f;
        Invoke("goFishing", 5f);
    }

    void goFishing()
    {
        int rand = Random.Range(1 , 6);
        if (rand == 5)
        {
            inv.chestNbr++;
            Debug.Log("+1 Chest");
        }
        else
            Debug.Log("+" + rand * 10 + " coins");

        fishBtn.SetActive(true);
        speed = 2f;
    }
}
