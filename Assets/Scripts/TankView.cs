using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    private TankController tankController;
    private float movement;
    private float rotate;


    private void Update()
    {
        Movement();

        if (movement != 0)
            tankController.Move(movement, 30);
        if (rotate != 0)
            tankController.Roatate(rotate, 40);
    }

    private void Movement() 
    {
        movement = Input.GetAxis("Vertical");
        rotate = Input.GetAxis("Horizontal");
    }
    public Rigidbody GetRigidbody() 
    {
        return rb;
    }
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

}
