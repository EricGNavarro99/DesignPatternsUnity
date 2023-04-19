using System.Collections.Generic;
using UnityEngine;

namespace Unity.AbstractFactory
{
    [CreateAssetMenu(menuName = "Custom/Weapons configuration")]
    public class WeaponsConfiguration : ScriptableObject
    {
        [SerializeField] private Weapon[] weapons;
        private Dictionary<string, Weapon> idToWeapon;

        private void Awake()
        {
            this.idToWeapon = new Dictionary<string, Weapon>();

            foreach (var weapon in this.weapons)
                this.idToWeapon.Add(weapon.Id, weapon);
        }

        public Weapon GetWeaponPrefabById(string id)
        {
            if (!this.idToWeapon.TryGetValue(id, out var weapon))
                throw new System.Exception($"Weapon with id {id} does not exist");

            return weapon;
        }
    }
}