using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cena : MonoBehaviour
{


  // Use this for initialization
  void Start()
  {
		
  }
	
  // Update is called once per frame
  void Update()
  {      

  }

  public void CarregaCena(string n)
  {

    SceneManager.LoadScene(n);


  }

  public void SairJogo()
  {

    Application.Quit();


  }


}
