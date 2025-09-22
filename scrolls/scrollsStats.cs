using UnityEngine;
using System.Collections;
using spells.spellFireball;
using System;


abstract class scrolls //Main way of attacking, can also heal, defend, and buff.
{
    int ATK;
    int DEF;
    int HP;
    int SPD;
    double JMPHT;
    int healing;
    int cooldown;
    int chargeTime;
    int duration;
    double CRTRT;
    double CRTDMG;
    int HBwidth;
    int HBheight;
    string name;
}