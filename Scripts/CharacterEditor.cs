using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEditor : MonoBehaviour
{
    public GameObject hair , eye1 , eye2 , shirt1 , shirt2 , shirt3 , pants1 , pants2 , pnt , playerInter;
    public Sprite[] hairList, eyesList, shirtList, shirtList2 , pantsList , pntList;
    SpriteRenderer sprHair , sprEye1 , sprEye2 , sprShirt1 , sprShirt2 , sprShirt3 , sprPants1 , sprPants2 ,sprPnt;
    public int countHair , countEy , countShirt , countPants;
    public GameObject editorUI, gameMap , gameChr;
    public bool isOpen;
    public SpriteRenderer playerHair , playerShirt1 , playerShirt2 , playerShirt3, playerEye1 , playerEye2 , playerPants1 , playerPants2 , playerPants;

    void Start()
    {
        sprHair = hair.GetComponent<SpriteRenderer>();
        sprEye1 = eye1.GetComponent<SpriteRenderer>();
        sprEye2 = eye2.GetComponent<SpriteRenderer>();
        sprShirt1 = shirt1.GetComponent<SpriteRenderer>();
        sprShirt2 = shirt2.GetComponent<SpriteRenderer>();
        sprShirt3 = shirt3.GetComponent<SpriteRenderer>();
        sprPants1 = pants1.GetComponent<SpriteRenderer>();
        sprPants2 = pants2.GetComponent<SpriteRenderer>();
        sprPnt = pnt.GetComponent<SpriteRenderer>();

        countPants = 0;
        countHair = 0;
        countEy = 0;
        countShirt = 0;

        isOpen = false;
    }

    
    void Update()
    {
        playerHair.sprite = sprHair.sprite = hairList[countHair];
        playerEye1.sprite = playerEye2.sprite = sprEye1.sprite = sprEye2.sprite = eyesList[countEy];
        playerShirt1.sprite = sprShirt1.sprite = shirtList[countShirt];
        playerShirt2.sprite = playerShirt3.sprite = sprShirt2.sprite = sprShirt3.sprite = shirtList2[countShirt];
        playerPants2.sprite = playerPants1.sprite = sprPants1.sprite = sprPants2.sprite = pantsList[countPants];
        playerPants.sprite = sprPnt.sprite = pntList[countPants];

        editorUI.SetActive(isOpen);
        gameMap.SetActive(!isOpen);
        gameChr.SetActive(!isOpen);

        if (Input.GetKeyDown(KeyCode.Tab))
            isOpen = !isOpen;

         

    }

    public void Up()
    {
        countHair++;
        if (countHair > 2)
            countHair = 0;
    }

    public void Down()
    {
        countHair--;
        if (countHair < 0)
            countHair = 2;
    }
    public void UpEyes()
    {
        countEy++;
        if (countEy > 2)
            countEy = 0;
    }

    public void DownEyes()
    {
        countEy--;
        if (countEy < 0)
            countEy = 2;
    }

    public void UpShirt()
    {
        countShirt++;
        if (countShirt > 2)
            countShirt = 0;
    }

    public void DownShirt()
    {
        countShirt--;
        if (countShirt < 0)
            countShirt = 2;
    }

    public void UpPants()
    {
        countPants++;
        if (countPants > 2)
            countPants = 0;
    }

    public void DownPants()
    {
        countPants--;
        if (countPants < 0)
            countPants = 2;
    }

    public void CloseChrEditor()
    {
        isOpen = false;
    }
}
