using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour{
    //Target形の「target」をつくる
    Target target;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //
    void OnCollisionEnter(Collision col){
        //
        if(col.gameObject.tag == "Target"){
            //当たった相手からスクリプトの情報を手に入れる
            target = col.gameObject.GetComponent<Target>();
            //target(スクリプト)のDamage()関数を呼ぶ
            target.Damage();

            Destroy(gameObject);
        }
    }
}
