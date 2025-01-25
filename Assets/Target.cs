using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;//

public class Target : MonoBehaviour
{
    public GameObject target;//
    UnityEngine.AI.NavMeshAgent agent;//
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();//
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;//agentの目的地
    }

    //どこからアクセス
    public void Damage(){
        //float timer
        float timer = 0.3f;
        //自分自身のゲームオブジェクト
        Destroy (gameObject,timer);
    }
}
