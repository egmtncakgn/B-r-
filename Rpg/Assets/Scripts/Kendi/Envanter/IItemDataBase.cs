using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystem;

public class IItemDataBase : MonoBehaviour {

    public List<IItem> itemler;

    void Awake()
    {
        IItem.add(ne);
    }
}
