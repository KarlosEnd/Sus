using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sus : MonoBehaviour
{
    public GameObject body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                collision.gameObject.GetComponent<Animator>().Play("Dead");
            }
        }
        
    }
}
