using System;


namespace SimpleTeam.GameOne.Message
{
    using TypeID = Byte;
    /**
    <summary> 
    Реестр всех типов сообщений.
    </summary>
    */
    public enum HelperMessageID : byte//TypeID
    {
        Account,
        Chat,
        Profile,
        GameMap,
        GameState,
        GamerCommand
    }
}
