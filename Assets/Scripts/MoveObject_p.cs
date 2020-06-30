using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject_p : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    private Vector3 resetPosition;

    // Start is called before the first frame update
    void Start()
    {
        //rigidbodyの参照を得る
        rb = GetComponent<Rigidbody>();

        //初期位置を保存
        resetPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //ｒを押したら物体を初期位置に戻し、回転をリセット
        if (Input.GetKeyDown("r"))
        {
            transform.position = resetPosition;

            transform.rotation = Quaternion.identity;
        }

        //横方向と縦方向の入力を取得
        float xAxis = Input.GetAxisRaw("Horizontal");
        float zAxis = Input.GetAxisRaw("Vertical");

        //移動ベクトルを得る
        Vector3 movePosition = new Vector3(xAxis, 0, zAxis)*speed;

        //物体を元位置＋ベクトルに移動
        rb.MovePosition(transform.position+movePosition);


    }
}
