/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 14, 2023 
 * File: EquipmentControlDisplay.cs
 * 
 * Class: EquipmentControlDisplay
 * Purpose: Lets the user change lab equipment settings from a control pannel. 
 * 
 **/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LabManagers
{
    public class EquipmentControlDisplay : MonoBehaviour
    {
        [SerializeField] private Button controlsButton;
        [SerializeField] private TMP_Dropdown controlDropdown;
        [SerializeField] private Image equipControlSubPanel;

        private bool showControls;

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
            showControls = false;
            equipControlSubPanel.gameObject.SetActive(showControls);
            equipType = EquipmentType.none;

            // setup the button on click actions
            controlsButton.onClick.AddListener(ShowEquipmentControls);

            // setup the dropdown menu actions
            controlDropdown.onValueChanged.AddListener(SetEquipmentType);
        }

        private void ShowEquipmentControls()
        {
            if (showControls)
            {
                showControls = false;
                equipControlSubPanel.gameObject.SetActive(showControls);
                equipType = EquipmentType.none;
            }
            else
            {
                showControls = true;
                equipControlSubPanel.gameObject.SetActive(showControls);
            }
        }

        private void SetEquipmentType(int num)
        {
            //int num = controlDropdown.value;
            equipType = (EquipmentType)num;
            Debug.Log("dropdown equipmentType: " + equipType.ToString());
        }


        private void DisplayController(int num)
        {
            //throw new NotImplementedException();
        }


        // Start is called before the first frame update
        void Start()
        {

        }


        // Update is called once per frame
        void Update()
        {
            
        }



    }
}