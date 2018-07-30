using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controls : MonoBehaviour {

    public float Player_Walk_Speed; // a public float that will help us determinne our players walk speed

    public KeyCode Forward_Button; // a public keycode for the button that will push our player forward
    public KeyCode Back_Button; // a public keycode for the button that will push our player backward
    public KeyCode Left_Buttonn; // a public keycode for the buttonn that will push our player left
    public KeyCode Right_Button; // a public keycode for the button that will push our player right

    Rigidbody My_Player_Rigidbody; // getting a rigidbody component for our player

	// Use this for initialization
	void Start () {

        My_Player_Rigidbody = GetComponent<Rigidbody>(); // assigining the rigidbody of this gameobject to my player rigidbody component
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(Forward_Button)){ // if our forward button is ever pressed

            My_Player_Rigidbody.MovePosition(transform.position + transform.forward * Player_Walk_Speed * Time.deltaTime); // moving or player at the speed of player walk speed

        }

        if (Input.GetKey(Back_Button)){ // if our back button is ever pressed

            My_Player_Rigidbody.MovePosition(transform.position - transform.forward * Player_Walk_Speed * Time.deltaTime); // moving or player at the speed of player walk speed

        }

        if (Input.GetKey(Left_Buttonn)){ // if our left button is ever pressed

            My_Player_Rigidbody.MovePosition(transform.position - transform.right * Player_Walk_Speed * Time.deltaTime); // moving or player at the speed of player walk speed

        }


        if (Input.GetKey(Right_Button)){ // if our right button is ever pressed

            My_Player_Rigidbody.MovePosition(transform.position + transform.right * Player_Walk_Speed * Time.deltaTime); // moving or player at the speed of player walk speed

        }


		
	}
}
