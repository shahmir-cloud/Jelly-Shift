using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int health = 3;
    public bool gameover = false;
    public Text TextScore;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextScore.text = "Health " + health.ToString();
        if(health < 0)
        {
            gameover = true;
        }

        if(gameover == true)
        {
            image.gameObject.SetActive(true);
        }
    }
}
