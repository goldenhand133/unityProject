using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowingWithoutRotation : MonoBehaviour
{
    //目標カメラの参照を取る
    public GameObject mainCamera;

    //カメラとのベクトルを格納する変数
    private Vector3 VectorToCamera;

    // Start is called before the first frame update
    void Start()
    {
        //初期位置のカメラとのベクトルを代入
        VectorToCamera = transform.position - mainCamera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //常に同じベクトルを維持する
        mainCamera.transform.position = transform.position - VectorToCamera;
    }
}
