using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public GameObject connectedLock;
    public PressurePlateScript pressurePlate1;
    public PressurePlateScript pressurePlate2;
    public PressurePlateScript pressurePlate3;
    public int neededToUnlock=1;
    
    // Use this for initialization
    void Start()
    {
        GetComponent<GameObject>();
    }
    // if all 3 pressure plates is activated the the connected locks are disabled if not all of them are actiated then they are enabled again
    void Update()
    {
        if(pressurePlate1.doorOpen + pressurePlate2.doorOpen + pressurePlate3.doorOpen == neededToUnlock)
        {
             connectedLock.SetActive(false);
        }
        if (pressurePlate1.doorOpen + pressurePlate2.doorOpen + pressurePlate3.doorOpen < neededToUnlock)
        {
            connectedLock.SetActive(true);
        }
    }
}
