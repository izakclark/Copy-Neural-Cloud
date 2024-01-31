using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    /// <summary>
    /// 캐릭터의 스텟에 관한 모음
    /// </summary>
    #region
    protected string c_Name { get; set; }
    protected int hp { get; set; }
    protected int physicsAtk { get; set; }
    protected int M_Atk { get; set; }
    protected int physicsDef {  get; set; }
    protected int M_Def { get; set;}
    protected int atkSdp { get; set; }
    protected float critprobability {  get; set; }
    protected float critDmgmagnification { get; set; }
    protected int physicsPenetrate {  get; set; }
    protected int m_Penetrate { get; set; }
    protected float Agi {  get; set; }
    protected int recovery {  get; set; }
    protected int skillRechargeSpd { get; set; }
    protected int effectresistance { get; set; }
    protected float dmgReflect { get; set; }
    protected float dmgAmplifier { get; set; }
    protected float dmgDeduction {  get; set; }
    protected float healEffect { get; set; }

    protected float movementSpd {  get; set; }
    protected int atkRange {  get; set; }
    #endregion



}
