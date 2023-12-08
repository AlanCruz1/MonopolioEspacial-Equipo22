using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject enemBullet;
    public Transform enemBulletPos;
    private double timer ; 
    // Start is called before the first frame update
    void Start()
    {
        timer = 1.5;
    }

    // Update is called once per frame
    void Update()
    {
        timer += 0.5 * Time.deltaTime;
        if(timer >= 1.5)
        {
            timer = 0;
            shoot();
        }

    }

    void shoot()
    {
        Instantiate(enemBullet, enemBulletPos.position,Quaternion.identity);
    }

}
