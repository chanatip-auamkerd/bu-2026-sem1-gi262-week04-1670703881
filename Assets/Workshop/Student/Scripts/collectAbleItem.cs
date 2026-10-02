using System.IO.MemoryMappedFiles;
using UnityEngine;

namespace Solution
{
    public class CollectAbleItem : Identity
    {
        public override bool Hit()
        {
            Debug.Log("Item: " + Name + " has been picked up.");
            // ทำลายไอเท็มออกจากฉาก
            Destroy(gameObject);
            mapGenerator.player.inventory.AddItem(name, 1);
            

            return true;
        }
    }
}

