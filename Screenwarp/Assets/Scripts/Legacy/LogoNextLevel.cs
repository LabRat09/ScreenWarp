using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoNextLevel : MonoBehaviour {
    public int levelToLoad = 0;

    // Use this for initialization
    void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void NextLevel()
    {
        print("Changing Level");
        SceneManager.LoadScene(levelToLoad);
    }
}
