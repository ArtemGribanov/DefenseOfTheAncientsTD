using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standartTurret;
    public TurretBlueprint missileLauncher;
    public TurretBlueprint laserBeamer;


    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandartTurrert()
   {
       Debug.Log("Standart Turret Selected");
        buildManager.SelectTurretToBuild(standartTurret);
   }
   public void SelectMissleLauncher()
   {
       Debug.Log("Missle Launcher Selected");
        buildManager.SelectTurretToBuild(missileLauncher);
   }
   public void SelectLaserBeamer()
   {
       Debug.Log("Laser baemer Selected");
       buildManager.SelectTurretToBuild(laserBeamer);
   }
}
