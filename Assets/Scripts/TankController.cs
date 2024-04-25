using UnityEngine;
public class TankController 
{
    private TankModel tankModel;
    private TankView tankView;
    private Rigidbody rb;

    //Getter
    public TankModel GetTankModel()
    {
        return tankModel;
    }

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.GetRigidbody();

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        tankView.ChangeTankColor(tankModel.color);
    }

    public void Move(float Movement, float MovementSpeed)
    {
        rb.velocity = tankView.transform.forward * Movement * MovementSpeed;
    }

    public void Roatate(float Rotate, float RotationSpeed)
    {
        Vector3 rotatio = new Vector3(0f, Rotate * RotationSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(rotatio * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }


}
