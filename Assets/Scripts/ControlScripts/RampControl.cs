using LabEquipment;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampControl : EquipmentControl
{

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        //equipment = equipmentObj.GetComponent<Equipment>() as Ramp;
        initializeControls();
    }


    public override void initializeControls()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void showControls()
    {
        throw new System.NotImplementedException();
    }
}
