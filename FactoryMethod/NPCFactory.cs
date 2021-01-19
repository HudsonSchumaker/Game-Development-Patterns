using UntyEngine;

// Hudson Schumaker

public class NPCFactory : MonoBehavior
{
    public INPC GetNPC(NPCType type) 
    {
        switch(type)
        {
            case NPCType.Beggar:
               NPC beggar = new Beggar();
            return beggar;
            
            case NPCType.Farmer:
               NPC farmer = new Farmer();
            return farmer;
            
            case NPCType.Shopowner:
               NPC shopowner = new Shopowner();
            return shopowner;
        }
        return null;
    }
}
