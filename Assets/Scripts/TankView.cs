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

    private void Start()
    {
        GameObject mainCamera = GameObject.Find("Main Camera");
        mainCamera.transform.SetParent(transform);
        mainCamera.transform.position = new Vector3(0f, 3f, -4f);
    }

    private void Update()
    {
        Movement();

        if (movement != 0)
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        if (rotate != 0)
            tankController.Roatate(rotate, tankController.GetTankModel().rotationSpeed);
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
