﻿namespace Loki.Net
{
    public enum MapleServerOperationCode : short
    {
        Login = 0x00,
        Link = 0x01,
        MasterLogin = 0x02,
        ServerStatus = 0x03,
        Gender = 0x04,
        TermsOfService = 0x05,
        PinOperation = 0x06,
        PinAssigned = 0x07,
        AllCharactersList = 0x08,
        ServerList = 0x0A,
        CharacterList = 0x0B,
        ServerIP = 0x0C,
        CharacterName = 0x0D,
        AddNewCharacterEntry = 0x0E,
        DeleteCharacter = 0x0F,
        ChangeChannel = 0x10,
        Ping = 0x11,
        ChannelSelected = 0x14,
        RelogResponse = 0x16,
        ModifyInventoryItem = 0x1A,
        UpdateStats = 0x1C,
        GiveBuff = 0x1D,
        CancelBuff = 0x1E,
        UpdateSkills = 0x21,
        FameResponse = 0x23,
        ShowLog = 0x24,
        ShowNotes = 0x26,
        TrockLocations = 0x27,
        LieDetector = 0x28,
        ReportResponse = 0x2A,
        EnableReport = 0x2C,
        UpdateMount = 0x2D,
        ShowQuestCompletion = 0x2E,
        SendTitleBox = 0x2F,
        CharacterInformation = 0x3A,
        WarpToMap = 0x72,
        SpawnCharacter = 0x91,
        RemoveCharacter = 0x92,
        ChatText = 0x93,
        MoveCharacter = 0xA7,
        FacialExpression = 0xAF,
        UpdateCharacterLook = 0xB3,
        ShowForeignEffect = 0xB4,
        SpawnMonster = 0xD0,
        KillMonster = 0xD1,
        SpawnMonsterController = 0xD2,
        MoveMonster = 0xD3,
        MoveMonsterResponse = 0xD4,
        ApplyMonsterStatus = 0xD6,
        CancelMonsterStatus = 0xD7,
        DamageMonster = 0xDA,
        AriantThing = 0xDD,
        ShowMonsterHP = 0xDE,
        DropItemFromMapObject = 0xEE,
        RemoveItemFromMap = 0xEF,
        ServerMessage = 0x41,
        YellowTip = 0x4A,
        SpawnNpc = 0xE3,
        RemoveNpc = 0xE4,
        RequestNpcController = 0xE5,
        UpdateNpc = 0xE6,
        NpcTalk = 0x10E,
        OpenNpcShop = 0x10F,
        ConfirmShopTransaction = 0x110,
        SpawnHiredMerchant = 0xEB,
        DestroyHiredMerchant = 0XEC,
        UpdateHiredMerchant = 0xED,
        CloseRangeAttack = 0xA8,
        RangedAttack = 0xA9,
        MagicAttack = 0xAA,
        PlayerInteraction = 0x118,
        ShowStatusInfo = 0x24,
        UpdateQuestInfo = 0xC1,
        UpdateCharacterBox = 0x96,
        Cooldown = 0xCE,
        GiveForeignBuff = 0xB5,
        CancelForeignBuff = 0xB6,
        SkillEffect = 0xAC,
        CancelSkillEffect = 0xAD,
        ShowItemGainInChat = 0xBC, //TODO:Change to more appropriate name
        KeyMap = 0x12A,
        ViciousHammer = 0x13D
    }
}