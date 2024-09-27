using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public TankTypes tankType;
        public float movementSpeed;
        public float rotationSpeed;
        public Material color;
    }

    public List<Tank> tank;

    [SerializeField]
    private TankView tankView;

    public void CreateTank(TankTypes tankType) {

        if (tankType == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(tank[2].movementSpeed, tank[2].rotationSpeed, tank[2].tankType, tank[2].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if (tankType == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(tank[1].movementSpeed, tank[1].rotationSpeed, tank[1].tankType, tank[1].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if (tankType == TankTypes.GreenTank) 
        {
            TankModel tankModel = new TankModel(tank[0].movementSpeed, tank[0].rotationSpeed, tank[0].tankType, tank[0].color);
            TankController tankController = new TankController(tankModel, tankView);
        }
    }
}
