using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScrip : MonoBehaviour
{

	public CharacterController2D controller;
	public Animator animator;
    public float MovementSpeed = 40f;

    float HorizontalPosition = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
        HorizontalPosition = Input.GetAxisRaw("Horizontal")*MovementSpeed;
        //Debug.Log(HorizontalPosition);
        animator.SetFloat("Speed",Mathf.Abs(HorizontalPosition));

    	if(Input.GetButtonDown("Jump"))
    	{
    		Debug.Log(jump);
    		jump = true;
    	}

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Enemies")
        {
            StartCoroutine(MyFunction(collision, 0.2f));
            if(Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
        }
    }
    
    IEnumerator MyFunction(Collision2D collision, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "Enemies")
        {
            Debug.Log("test1");
            Destroy(collision.gameObject);
        }
    }

    void FixedUpdate()
    {
    	//Player Movement
    	controller.Move(HorizontalPosition * Time.fixedDeltaTime,false,jump);
        jump=false;
    }

    
}
