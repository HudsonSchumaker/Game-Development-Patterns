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
        }
    }
    
}
