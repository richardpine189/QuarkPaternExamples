using System;
using System.Collections;
using System.Collections.Generic;

public interface IHero
{
    event Action<int> OnHealthUpdated;
}
