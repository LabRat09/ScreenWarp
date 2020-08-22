
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwapOnPress : MonoBehaviour {

    public int levelToLoad = 0;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetButtonDown("Submit"))
        {
            print("Changing Level");
            SceneManager.LoadScene(levelToLoad);
        }
	}
}
