using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour {


	float speed = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

    MoveTeclado();

	}

	void MoveTeclado() {

		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");

		Vector2 movement = new Vector2(horizontal, 0);

		Rigidbody2D rigi2d = GetComponent <Rigidbody2D>();

		if (vertical != 0)
		{


			rigi2d.MovePosition(rigi2d.position + movement * speed * Time.deltaTime);

		}

		if (horizontal != 0)
		{

			rigi2d.MovePosition(rigi2d.position + movement * speed * Time.deltaTime);

		}



	}
      

}
