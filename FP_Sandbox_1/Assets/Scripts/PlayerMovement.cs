using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //          ПЕРЕМЕННЫЕ
    //          PUBLIC 
    public CharacterController controller; // компонент character controller 
    public float movementSpeed = 12.0f; // скорость движения 
    public float sprintingAppender = 6.0f; // регулятор скорости при спринте
    public float gravity = -9.81f; // сила гравитации (-9,81 по умолчанию)
    public float jumpHeight = 2.0f; // высота прыжка

    // проверка на соприкосновение с землей
    public Transform groundCheck; 
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    //          PRIVATE 
    private Vector3 _velocity;
    private bool _isGrounded;

    //          ФУНКЦИИ
    private void FixedUpdate() // для физики
    {
        // создаст невидимую сферу на месте объекта GroundCheck | будет true, когда соприкоснется с чем-нибудь в groundMask
        _isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); 
        
        if (_isGrounded && (_velocity.y < 0.0f))
        {
            _velocity.y = -2.0f; // -2.0f рекомендуется, чтобы наверняка зачло
        }
    } 
   
    private void Update() // выполняется каждый кадр 
    {
        //    БЛОК УПРАВЛЕНИЯ С КЛАВИАТУРЫ
        //    WASD
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z; // направление движения персонажа
        controller.Move(move * movementSpeed * Time.deltaTime);

        // свободное падение
        // по формуле [ deltaY = 0.5 * g * t2 ] свободного падения
        _velocity.y += gravity * (Time.deltaTime); 
        controller.Move(_velocity * Time.deltaTime);

        //    ПРЫЖОК
        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _velocity.y = Mathf.Sqrt((-2) * jumpHeight * gravity); // формула [ sqrt(h * -2 * g) ] 
        }

        // СПРИНТ 
        if (Input.GetKeyDown(KeyCode.LeftShift))
            movementSpeed += sprintingAppender;
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            movementSpeed -= sprintingAppender; 

    }
}
