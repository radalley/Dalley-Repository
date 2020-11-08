using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text textbox;
    public int waveTot = 1;
    public bool loss = false;
    private ScoreManager scoreManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        scoreManagerScript = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();

        textbox.text = "Wave: 0";
    }
    
    // Update is called once per frame
    void Update()
    {
        
        if (loss == false)
        {
            
            if (waveTot >= 10)
            {
                textbox.text = "You Win! Press R to try again!";
            }
            else
            {
                textbox.text = "Wave " + waveTot;
            }
        }
        else
        {
            textbox.text = "You Lose! Press R To Try Again";
        }

        //Press R to restart if game is over
        if (Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
        
    }
}
