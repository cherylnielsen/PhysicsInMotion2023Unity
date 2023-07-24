/**
 * MS Computer Science Graduate Project: Physics In Motion
 * San Francisco State University, San Francisco, CA
 * 
 * Author: Cheryl Nielsen
 * Version: July 22, 2023  
 * File: Cart.cs
 * 
 * Class: Cart
 * Purpose: Stores and adjusts the settings for the cart.
 * Inherits all items from Block and Equipment
 **/

namespace LabEquipment
{
    public class Cart : Block
    {
        // inherits all items from Block and Equipment  

        public Cart() 
        { 
            initializeSettings();
        }

        public override void initializeSettings()
        {
            EquipmentType = "cart";
            Description = "cart";
            Category = "cart";

            units = "kg";

            minMass = 0.0f;
            maxMass = 20.0f;
            Mass = 2.0f;
        }

    }
}