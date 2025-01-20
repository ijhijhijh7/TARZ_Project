public enum E_Audio
{
    // BGM
    #region BGM
    None = -1,
    Stage_1_BGM,
    Stage_2_BGM,

    #endregion

    // SFX

    #region 캐릭터

    Char_Dash = 10,
    Char_RangeAttack,
    Char_Walk,
    Char_AfterJump,
    Char_Jump,
    Char_Damaged,
    Char_Dead,
    Char_DashMeleeAttack,
    Char_ArmUnit,
    Char_MeleeSkill_1,
    Char_MeleeSkill_2,
    Char_Drain,
    Char_LongRangeSkill_3,
    Char_LongRangeSkill_4,
    Char_LongRangeSkill_5_Rotate,
    Char_LongRangeSkill_5_Shoot,

    #endregion

    #region 몬스터

    Base_Idle = 40,
    Base_Encounter = 41,
    Base_Die = 42,
    Dog_Idle = 43,
    Dog_Encounter = 44,
    Dog_Die = 45,
    Elite1_Idle = 46,
    Elite1_Encounter = 47,
    Elite1_Jump = 48,
    Elite1_Die = 49,
    Elite2_Idle = 50,
    Elite2_Encounter = 51,
    Elite2_Bomb = 52,
    Elite2_Die = 53,
    Boss_Attack = 54,
    Boss_Encounter = 55,
    Boss_Skill1_Dash = 56,
    Boss_Skill2_Bomb = 57,
    Boss_Gimmick = 58,
    Boss_Groggy = 59,
    Boss_Die = 60,

    #endregion

    #region UI

    UI_ButtonClick = 100,
    UI_ButtonClick2,
    UI_ButtonMove,
    UI_GetChip,
    UI_ShopOnOff,
    UI_ShopConfirm,
    UI_Backpack,
    UI_PopUp,
    UI_GameOver

    #endregion
}