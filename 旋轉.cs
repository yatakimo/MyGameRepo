using UnityEngine;

public class CrystalRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // 控制旋轉速度的變量

    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed, Space.Self);
    }
}
