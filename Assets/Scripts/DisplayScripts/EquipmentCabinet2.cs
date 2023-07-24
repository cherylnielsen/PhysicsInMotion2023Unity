/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 14, 2023  
 * File: EquipmentCabinet2.cs
 * 
 * Class: EquipmentCabinet2
 * Purpose: Lets the user add lab equipment to the lab room.  Equipment is placed at 
 * the location the user chooses by clicking with the mouse.  A control pannel is also 
 * added to the lab room for the chosen equipment.
 * 
 * The user clicks a button on the equipment list to choose an equipment item.
 * The user then clicks a location in the lab room to place the equipment item.
 * The chosen equipment item is added to the room at that location and a 
 * 
 **/


using LabEquipment;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

namespace LabManagers
{
    public class EquipmentCabinet2 : MonoBehaviour
    {
        [SerializeField] private Button cabinetButton;
        [SerializeField] private Button cartBtn, blockBtn, rampBtn, sensorBtn;
        [SerializeField] private Image buttonPanel;

        private bool showCabinet;

        public enum EquipmentType
        {
            none = -1, cart = 0, block, ramp, sensor
        }

        private EquipmentType equipType;

        public EquipmentType EquipType
        {
            get { return equipType; }
            set { equipType = value; }
        }


        // Awake is called when the script instance is being loaded
        private void Awake()
        {
            showCabinet = false;
            buttonPanel.gameObject.SetActive(showCabinet);
            equipType = EquipmentType.none;

            // setup the button on click actions
            cabinetButton.onClick.AddListener(ShowEquipmentCabinet);

            // Event actions to set the equipment type to create (Instantiate) when that equipment type is chosen.
            cartBtn.onClick.AddListener(delegate { SetEquipmentType(EquipmentType.cart); });
            blockBtn.onClick.AddListener(delegate { SetEquipmentType(EquipmentType.block); });
            rampBtn.onClick.AddListener(delegate { SetEquipmentType(EquipmentType.ramp); });
            sensorBtn.onClick.AddListener(delegate { SetEquipmentType(EquipmentType.sensor); });

        }


        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        /**
        public void OnGUI()
        {
            
        }
        **/

        public void SetEquipmentType(EquipmentType equip)
        {
            equipType = equip;
            Debug.Log("equipmentType: " + equipType.ToString());
        }


        public void SetEquipmentType(int num)
        {
            equipType = (EquipmentType) num;
            Debug.Log("equipmentType: " + equipType.ToString());
        }


        void ShowEquipmentCabinet()
        {
            if (showCabinet)
            {
                showCabinet = false;
                buttonPanel.gameObject.SetActive(showCabinet);
                equipType = EquipmentType.none;
            }
            else
            {
                showCabinet = true;
                buttonPanel.gameObject.SetActive(showCabinet);
            }

        }

        

    }
}