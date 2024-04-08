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

    private void Start()
    {
        CreateTank();
    }

    private void CreateTank() {
        TankModel tankModel = new TankModel(tank[2].movementSpeed, tank[2].rotationSpeed, tank[2].tankType, tank[2].color);
        TankController tankController = new TankController(tankModel ,tankView);
    }
}
