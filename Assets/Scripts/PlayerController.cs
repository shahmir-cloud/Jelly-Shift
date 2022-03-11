using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameManager gamem;
    // Start is called before the first frame update
    void Start()
    {
        gamem = GameObject.FindGameObjectWithTag("gamemanager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.localScale.y < 2 )
        {
            transform.localScale = transform.localScale + new Vector3(0, 0.05f, -0.05f);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.localScale.y > 0.5f)
        {
            transform.localScale = transform.localScale + new Vector3(0, -0.05f, 0.05f);

        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("obstical"))
        {
            gamem.health--;
            Destroy(collision.gameObject);
        }
    }

}
