using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScene : MonoBehaviour
{
	public string Scene;
	public Button Button;

	void Start () 
	{
		Button btn = Button.GetComponent<Button>();
		btn.onClick.AddListener(LoadLevel);
	}

    public void LoadLevel()
    {
        SceneManager.LoadScene(Scene);
    }
}
