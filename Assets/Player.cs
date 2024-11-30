using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]//エディタでできるらしいよ
    private float jumpPower = 4;//ジャンプ力

    [SerializeField]
    private float moveSpeed = 10;//移動

    private CharacterController characterController;
    private Vector3 velocity;//

    public float sensitivityX = 15F;//マウス横の強さ
    public float sensitivityY = 15F;//縦の強さ

    public float minimumX = -360F;//横の回転の最低値
    public float maximumX = 360F;//横の回転の最大値

    public float minimumY = -60F;//縦の回転の最低値
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
            characterController.Move(this.gameObject.transform.forward * moveSpeed * Time.deltaTime);//前方にmovespeed 時間経過分動かす

        }
        if(Input.GetKey(KeyCode.S))//
        {
            characterController.Move(this.gameObject.transform.forward * -1 * moveSpeed * Time.deltaTime);//
        }
        if (Input.GetKey(KeyCode.A))// もし、Aキーがおされたら、
        {
            characterController.Move(this.gameObject.transform.right * -1 * moveSpeed * Time.deltaTime);// 左にMoveSpeed * 時間経過分動かす
        }

        if (Input.GetKey(KeyCode.D))// もし、Dキーがおされたら、
        {
            characterController.Move(this.gameObject.transform.right * moveSpeed * Time.deltaTime);// 右にMoveSpeed * 時間経過分動かす
        }
        
        characterController.Move(velocity * Time.deltaTime);//
        velocity.y += Physics.gravity.y * Time.deltaTime;//

        if(characterController.isGrounded)//
        {
            velocity.y = jumpPower;//
        }

        rotationX=transform.localEulerAngles.y + Input.GetAxis("Mouse X")*sensitivityX;//

        rotationY += Input.GetAxis("Mouse Y")*sensitivityY;//
        rotationY = Mathf.Clamp(rotationY,minimumY,maximumY);//

        verRot.transform.localEulerAngles = new Vector3(-rotationY,0,0);//
        horRot.transform.localEulerAngles = new Vector3(0,rotationY,0);//
    }

    
}
