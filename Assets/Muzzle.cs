using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzzle : MonoBehaviour{    
    //どこらアクセス
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    if(Input.GetMouseButtonDown(0)){
        Shot();
      }
    }
    //関数
    void Shot(){
        //gameObject形の[ブレット]
        GameObject bullet;
        //
        bullet = GameObject.Instantiate(bulletPrefab);
        //
        bullet.transform.position = transform.position;
        //
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
    }
    
}  
