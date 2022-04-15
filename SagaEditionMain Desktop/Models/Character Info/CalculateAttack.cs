using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaEditionMain_Desktop.Models.Character_Info
{
    public class CalculateAttack
    {
        public static int CalculateBaB(List<CharacterClasses.CharacterClassBase> classList, int bonusBaB)
        {
            int bab = 0;
            foreach (var playerClass in classList)
            {
                bab = bab + playerClass.BaseAttackBonus;
            }
            bab = bab + bonusBaB;
            return bab;
        }

        public static int CalculateRangedAttack(int baseAttackBonus, int dexMod)
        {
            int rangedAttackBonus = baseAttackBonus + dexMod;
            return rangedAttackBonus;

        }

        public static int CalculateMeleeAttack(int baseAttackBonus, int heroicLevel, int strengthModifier)
        {
            int meleeAttackBonus = baseAttackBonus + strengthModifier + (heroicLevel / 2);
            return meleeAttackBonus;
        }

        public static int CalculateRangedDamageBonus(int heroicLevel)
        {
            int rangedAttackDamageBonus = (heroicLevel / 2);
            return rangedAttackDamageBonus;
        }

        public static int CalculateMeleeDamageBonus(int heroicLevel, int strengthModifier)
        {
            int meleeAttackDamageBonus = strengthModifier + (heroicLevel / 2);
            return meleeAttackDamageBonus;
        }
    }
}
