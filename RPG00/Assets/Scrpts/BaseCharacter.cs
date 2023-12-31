using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter
{
    private string name;
    private string description;
    private float strength;
    private float defence;
    private float dexterity;
    private float intelligence;
    private float health;

    public string NAME
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string DESCRIPTION
    {
        get { return this.description; }
        set { this.description = value; }
    }

    public float STRENGTH
    {
        get { return this.strength; }
        set { this.strength = value; }
    }

    public float DEFENCE
    {
        get { return defence; }
        set { this.defence = value; }
    }

    public float DEXTERITY
    {
        get { return this.dexterity; }
        set { this.dexterity = value; }
    }

    public float INTELLIGENCE
    {
        get { return this.intelligence; }
        set { this.intelligence = value; }
    }

    public float HEALTH
    {
        get { return this.health; }
        set { this.health = value; }
    }
}
