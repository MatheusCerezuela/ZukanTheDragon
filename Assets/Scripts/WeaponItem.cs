using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DS
{
    [CreateAssetMenu(menuName = "Item/Weapon Item")]
    public class WeaponItem : Item
    {
        public GameObject modePrefab;
        public bool isUnarmed;

        [Header("One Handed Attack Animations")]
        public string OH_Light_Attack_1;
        public string OH_Heavy_Attack_1;
    }
}

