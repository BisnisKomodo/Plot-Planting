using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movespeed;
    private Rigidbody2D rb2d;
    public LayerMask Landlayer;
    public Interact interacting;
    private bool canMove = true;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() 
    {
        if(canMove)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(horizontalInput, verticalInput) * movespeed;
            rb2d.velocity = movement;
        }

        else
        {
            rb2d.velocity = Vector2.zero;
        }
    }

    public void SetCanMove(bool state)
    {
        canMove = state;
    }

    public void CheckLand(GameObject Building, int money, float welfaretoadd, float EntertaintmentToAdd, float educationadd, float welfarereduction, float entertaintmentreduction, float educationreduction)
    {
        Collider2D[]Lands = Physics2D.OverlapCircleAll(transform.position, 0.1f, Landlayer);
        foreach(Collider2D Land in Lands)
        {
            Interact LandBuilds = Land.GetComponent<Interact>();
            LandBuilds.Builds(Building, money, welfaretoadd, EntertaintmentToAdd, educationadd, welfarereduction, entertaintmentreduction, educationreduction);
            Debug.Log(interacting);
        }
    }

    public void CheckLandV2()
    {
        Collider2D[]Lands = Physics2D.OverlapCircleAll(transform.position, 0.1f, Landlayer);
        foreach(Collider2D Land in Lands)
        {
            Interact LandBuilds = Land.GetComponent<Interact>();
            interacting = LandBuilds;
            Debug.Log(interacting);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SellBuilding();
        }
    }
    void SellBuilding()
    {
        Collider2D[] Lands = Physics2D.OverlapCircleAll(transform.position, 0.1f, Landlayer);
        foreach(Collider2D Land in Lands)
        {
            Interact LandBuilds = Land.GetComponent<Interact>();
            if (LandBuilds != null)
            {
                LandBuilds.SellBuilding();
            }
        }
    }
}
