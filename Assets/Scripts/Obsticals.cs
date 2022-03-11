using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticals : MonoBehaviour
{
    private float speed = 5;
    private Rigidbody enemyRb;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //enemyRb.AddForce(Vector3.right * speed);
        enemyRb.velocity = Vector3.right * speed;
        if(transform.position.x> 15)
        {
            Destroy(gameObject);
        }
    }
}
