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
        //public ParticleSystem MuzzleFlash;
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
            if (Input.GetButtonDown("Fire2"))
            {
                Power();
            }

        }

        void Equip(int p_ind)
        {
            if (currentWeapon != null) Destroy(currentWeapon);
            GameObject t_newWeapon = Instantiate(loadout[p_ind].prefab, weaponParent.position, weaponParent.rotation, weaponParent) as GameObject;
            t_newWeapon.transform.localPosition = Vector3.zero;
            t_newWeapon.transform.localEulerAngles = Vector3.zero;


            currentWeapon = t_newWeapon;
        }
        void Power()
        {
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range) && currentWeapon != null)
            {
                Debug.Log(hit.transform.name);

                Target target = hit.transform.GetComponent<Target>();
                if (target != null && currentWeapon != null)
                {
                    target.TakePower(damage);
                }
            }
        }
        void Shoot()
        {
            //MuzzleFlash.Play();
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range) && currentWeapon != null )
            {
                Debug.Log(hit.transform.name);

                Target target = hit.transform.GetComponent<Target>();
                if (target != null && currentWeapon != null)
                {
                    target.TakeDamage(damage);
                }
            }
        }

    }
}