using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour {
    public int levelToLoad;
    public void OnClicked()
    {
        print("Changing Level");
        SceneManager.LoadScene(levelToLoad);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
