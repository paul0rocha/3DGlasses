using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move: MonoBehaviour
{
      public void Teleport( Transform obj)
      transform.position = obj.position;
}
