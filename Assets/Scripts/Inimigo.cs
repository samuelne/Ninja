using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

  public GameObject enemy = null;


  // Use this for initialization
  void Start()
  {
		
  }
	
  // Update is called once per frame
  void Update()
  {
		

    SpawnEnemy();

  }


  int contador = 5;

  void SpawnEnemy()
  {

    if (contador > 0)
      {

        Instantiate(enemy);
        contador -= 1;
      }

  }
}
