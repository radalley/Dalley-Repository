using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoseOnFall : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textbox;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -51 || transform.position.y > 80)
        {
            //textbox.text = "You lose!";
            ScoreManager.gameOver = true;
        }
    }
}
