using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    public float mouseSensitivity = 200.0f; // чувствительность мыши
    private float _xRotation = 0.0f; // помогает контроллировать поворот
    public Transform playerBody; // персонаж
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // убирает курсор с экрана
    }

    private void Update()
    {   //                          БЛОК УПРАВЛЕНИЯ МЫШЬЮ
        // получение инпута 
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; 

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90.0f, 90.0f); // ограничивает движение по оси от -90 до 90 градусов

        transform.localRotation = Quaternion.Euler(_xRotation, 0.0f, 0.0f); // поворот камеры вверх-вниз
        playerBody.Rotate(Vector3.up * mouseX); // поворот камеры (вместе с игроком) вправо-влево
    }
}