using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
	public GameObject Game_UI;
	public GameObject Pause_UI;

	bool isPause = true;

    void Update()
    {
    	if(Input.GetKeyDown(KeyCode.Escape))
    	{
    		Debug.Log("test");
        	if (isPause == true) 
        	{
    			isPause = false;
    			Game_UI.SetActive(false);
    			Pause_UI.SetActive(true);
    			Time.timeScale = 0;
  			}
  			else if (isPause == false) 
  			{
    			isPause = true;
    			Game_UI.SetActive(true);
    			Pause_UI.SetActive(false);
    			Time.timeScale = 1;
    		}
    	}
    }
}
