using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class coinSpawnRandomizer : MonoBehaviour
{
    public float playerHorizontalPos;
    public float playerVerticalPos;
    public float coinHorizontalPos;
    public float coinVerticalPos;
    private float floorWidth = 10f;
    private float floorHeight = 10f;

    //This references the script playerMovement.cs ----------------------------------------------
    playerMovement playerMovement;
    [SerializeField] GameObject player;

    void Awake()
    {
        playerMovement = player.GetComponent<playerMovement>();
    }
    //big handy for connecting scripts
    //-------------------------------------------------------------------------------------------
    
    void Update()
    {
        //gets the players current position
        playerHorizontalPos = playerMovement.transform.position.z * -1;
        playerVerticalPos = playerMovement.transform.position.x;

        //gets the current position of the coin
        coinHorizontalPos = transform.position.z * -1;
        coinVerticalPos = transform.position.x;

        //playerHorizontalPos

        //detecting if the player is in collision with the coin
        if (playerHorizontalPos == coinHorizontalPos)
        {
            //make random numbers
            float randomXPos = Random.Range(-floorHeight, floorHeight);
            float randomZPos = Random.Range(-floorWidth, floorWidth);

            //move the coin to the new random position
            transform.Translate(randomXPos, 0, randomZPos);


        }




        

    }
}
