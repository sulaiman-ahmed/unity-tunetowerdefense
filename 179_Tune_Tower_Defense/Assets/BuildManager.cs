using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake ()
    {
      if(instance != null)
      {
        Debug.LogError("More than One BuildManager in scene");
        return;
      }
      instance = this;
    }

    public GameObject standardTurretPrefab;

    void Start()
    {
      turretToBuild = standardTurretPrefab;
    }

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
      return turretToBuild;
    }
}