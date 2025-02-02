using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Behavior : MonoBehaviour
{
    public float onscreenDelay = 3f;
    // Start is called before the first frame update
    void Start()
    {

        //destroys the bullet after float seconds
        Destroy(this.gameObject, onscreenDelay);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")){
            collision.gameObject.GetComponent<Enemy_Behavior>().damage();
        }
    }
}
