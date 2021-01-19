using UnityEngine;

// Hudson Schumaker
public NPCSpawner : MonoBehaviour
{
   private NPC_Factory factory = new NPCFactory();
   
   public void SpawnVillagers() 
   {
         INPC farmer = factory.GetNPC(NPCtype.Farmer);
         INPC beggar = factory.GetNPC(NPCtype.Beggar);
         INPC shopOwner = factory.GetNPC(NPCtype.Shopowner);
         
         farmer.Speak();
         beggar.speack();
         shopOwner.speak();
   }
}
