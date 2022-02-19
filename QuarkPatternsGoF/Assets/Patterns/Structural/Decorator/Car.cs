using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Car
{
    protected string carBrand;
    protected string carModel;
    protected int speed;

    public abstract string MaxSpeed();
}
