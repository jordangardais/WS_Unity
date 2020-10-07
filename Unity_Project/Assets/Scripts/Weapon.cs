using UnityEngine;



namespace Com.Array.Weapons
{
    public class Weapon : MonoBehaviour
    {
        public Gun[] loadout;
        public Transform weaponParent;
        public float damage = 10f;
        public float range = 100f;
        public Camera fpsCam;

        private GameObject currentWeapon;


        void Start()
        {

        }

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();

            }
            if (Input.GetKeyDown(KeyCode.Alpha1)) Equip(0);
        }

        void Equip(int p_ind)
        {
            if (currentWeapon != null) Destroy(currentWeapon);
            GameObject t_newWeapon = Instantiate(loadout[p_ind].prefab, weaponParent.position, weaponParent.rotation, weaponParent) as GameObject;
            t_newWeapon.transform.localPosition = Vector3.zero;
            t_newWeapon.transform.localEulerAngles = Vector3.zero;

            currentWeapon = t_newWeapon;
        }
        void Shoot()
        {
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);
            }
        }

    }
}