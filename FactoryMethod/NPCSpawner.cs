using UnityEngine;

// Hudson Schumaker

public NPCSpawner : MonoBehaviour
{
   private NPC_Factory factory = new NPCFactory();
   
   public void SpawnVillagers() 
   {
         INPC farmer = factory.GetNPC(NPCtype.Farmer);
         
   }
}
