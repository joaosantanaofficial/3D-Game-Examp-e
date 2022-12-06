using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   
    public CharacterController control;
    public float inputX;
    public float inputZ;
    
    public Vector3 movement;
    private Animator anim;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
       control = GetComponent<CharacterController>();  
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inputX == 0 && inputZ == 0)
        {
            anim.SetBool("Walk",false);
        }
        else{anim.SetBool("Walk",true);}
    inputX =  Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
    
               
    }
      void FixedUpdate()
    {
    movement = new Vector3 (inputX * moveSpeed * Time.deltaTime, 0 ,inputZ* moveSpeed* Time.deltaTime );
       control.Move(movement);
    
    }
    }
