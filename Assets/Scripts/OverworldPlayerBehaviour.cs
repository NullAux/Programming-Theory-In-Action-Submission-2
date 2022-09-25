using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldPlayerBehaviour : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }

    void MovePlayer()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector2 playerMovement = new Vector2(horizontalMovement, verticalMovement);
        transform.Translate(playerMovement * moveSpeed * Time.deltaTime);
    }

}
