using UnityEngine;

public class CameraViewer : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotSpeed = 2f;

    void Update()
    {
        // WASD前后左右移动相机
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h, 0, v) * moveSpeed * Time.deltaTime, Space.Self);

        // 按住鼠标右键拖动旋转视角
        if (Input.GetMouseButton(1))
        {
            float mx = Input.GetAxis("Mouse X");
            float my = Input.GetAxis("Mouse Y");
            transform.Rotate(-my * rotSpeed, mx * rotSpeed, 0);
        }
    }
}

