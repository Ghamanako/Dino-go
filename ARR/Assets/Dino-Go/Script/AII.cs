using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AII : MonoBehaviour
{
    public enum PlayerType
    {
        HUMAN, AI
    };

    public AIStates currentState = AIStates.Idle;
    public PlayerType player;
  

    public Animator animator;
    private Rigidbody rigidbody;

   
    public int index = 0;
    public float speed;
    private float random;
    private float randomSetTime;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {

        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
     

    }

   

    // Update is called once per frame
    void Update()
    {
        //if (player == PlayerType.HUMAN)
        //{
        //  UpdateHumanInput();
        //}
        //else
        //{
        //  UpdateAI();
        //}
        UpdateAI();
    }

    //public void UpdateHumanInput()
    //{
    // if (Input.GetAxis("Horizontal") > 0.1)
    //{
    //  animator.SetBool("walk", true);
    //}
    //else
    //{
    // animator.SetBool("walk", false);
    //}

    //if (Input.GetAxis("Horizontal") < -0.1)
    //{
    //  animator.SetBool("walk_back", true);
    //}
    //else
    //{
    //  animator.SetBool("walk_back", false);
    //}
    //if (Input.GetKeyDown(KeyCode.A))
    //{
    //  animator.SetTrigger("Punch");
    //}
    //if (Input.GetKeyDown(KeyCode.S))
    //{
    //  animator.SetTrigger("attack2");
    //}

    //}




    public void UpdateAI()
    {
        
      

        if (Time.time - randomSetTime > 1)
        {
            random = Random.value;
            randomSetTime = Time.time;
        }
        animator.SetFloat("random", random);
    }




   

    public bool attacking
    {
        get
        {
            return currentState == AIStates.Attack;
        }
    }

    public bool defending
    {
        get
        {
            return currentState == AIStates.Defend;
        }
    }

    public bool attack2
    {
        get
        {
            return currentState == AIStates.Attack2;
        }
    }

  

    public Rigidbody Body
    {
        get
        {
            return this.rigidbody;
        }
    }

    public bool HIT
    {
        get
        {
            return currentState == AIStates.Hit;
        }
    }

  

    public void pain()
    {
        animator.SetTrigger("Hit");
    }
}
