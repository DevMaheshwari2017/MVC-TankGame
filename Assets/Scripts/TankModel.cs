
using UnityEngine;
public class TankModel
{
    private TankController tankController;
    public float movementSpeed;
    public float rotationSpeed;
    public Material color;
    public TankTypes types;

    public TankModel(float movement, float rotation, TankTypes _types, Material _color) 
    {
        movementSpeed = movement;
        rotationSpeed = rotation;
        color = _color;
        types = _types;
    }
    public void SetTankController(TankController _tankController) 
    {
        tankController = _tankController;
    }
}
