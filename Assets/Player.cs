using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 8f;
    public float fireRate = 0.3f;
    public GameObject bulletPrefab;

    public Rigidbody2D rigid;
    private float input;
    private float lastFireTime;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.Space)){
            Fire();
        }
    }

    void Fire(){
        if (Time.time - lastFireTime > fireRate){
            GameObject bullet = Instantiate(bulletPrefab, transform.position + Vector3.up * 0.4f, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * 10f;
            lastFireTime = Time.time;

        }
    }

    private void FixedUpdate() {
        rigid.MovePosition(transform.position + Vector3.right * speed * input * Time.fixedDeltaTime);
    }
}
