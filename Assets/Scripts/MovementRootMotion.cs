using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRootMotion : MonoBehaviour
{
    bool movimiento;
    bool saltando;
    private Animator animatorController;

    void Start()
    {
      
        animatorController = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // TODO: Establecer animaciones
        animatorController.SetBool("SeMueve", vertical > 0);
        animatorController.SetBool("Saltando", Input.GetKeyDown(KeyCode.Space));
    }

}
