using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text textbox;
    public int score = 0;
    public int win = 0;
    // Start is called before the first frame update
    void Start()
    {
       // textbox = GetComponent<Text>();
        textbox.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
        if (score >= 10)
        {
            textbox.text = "Good job! Press P to pause and try the other levels!";
        }
        else
        {
            textbox.text = "Score: " + score;
        }
        //Press R to restart if game is over
       

    }
}
