using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 8f;

    private void Start(){
        Invoke("Kill", lifeTime);
    }

    void Kill(){
        if (gameObject != null){
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Enemy")){
            Destroy(collision.gameObject);
            //Destroy(gameObject);
            Kill();
        }
    }
}
