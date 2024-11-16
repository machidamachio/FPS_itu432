using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]//エディタでできるらしいよ
    private float jumpPower = 4;//ジャンプ力

    [SerializeField]
    private float moveSpped = 10;//移動

    private CharacterController CharacterController;
    private Vector3 velocity;//

    public float sensitivityX = 15F;//マウス横の強さ
    public float sensitivityY = 15F;//縦の強さ

    public float minimumX = -360F;//横の回転の最低値
    public float maximumX = 360F;//横の回転の最大値

    public float manimumY = -60F;//縦の回転の最低値
    public float maximumY = 60F;//最大値

    float rotationX = 0F;
    float rotationY = 0F;

    public GameObject verRot;//縦回転させるカメラ
    public GameObject horRot;//横回転させるオブジェクト

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();//characterControllerにCharacterControllerを代入
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))//もしWキーが押されたら
        {
            CharacterController.Move(this.gameObject.transform.forward * moveSpped * Time.deltaTime);//前方にmovespeed 時間経過分動かす

        }
        if(Input.GetKey(Keycode.S))//
        {
            CharacterController.Move(this.gameObject.transform.right * -1 * moveSpped * Time.deltaTime);//
        }
        if (Input.GetKey(KeyCode.A))// もし、Aキーがおされたら、
        {
            characterController.Move(this.gameObject.transform.right * -1 * moveSpeed * Time.deltaTime);// 左にMoveSpeed * 時間経過分動かす
        }

        if (Input.GetKey(KeyCode.D))// もし、Dキーがおされたら、
        {
            characterController.Move(this.gameObject.transform.right * moveSpeed * Time.deltaTime);// 右にMoveSpeed * 時間経過分動かす
        }
    }
}
