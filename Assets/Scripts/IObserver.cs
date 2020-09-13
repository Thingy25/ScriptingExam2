using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    void Receive(int skill);
    void Receive();
}
