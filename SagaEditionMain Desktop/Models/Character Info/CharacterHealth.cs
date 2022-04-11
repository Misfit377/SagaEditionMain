using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaEditionMain_Desktop.Models.Character_Info
{
    public class CharacterHealth
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int BonusHealth { get; set; }
        public int DamageReduction { get; set; }
        public int CurrentShieldRating { get; set; }
        public int MaxShieldRating { get; set; }
        public CharacterHealth()
        {

        }
        public CharacterHealth(int currentHealth, int maxHealth, int bonusHealth, int damageReduction, int currentShieldRating, int maxShieldRating)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
            BonusHealth = bonusHealth;
            DamageReduction = damageReduction;
            CurrentShieldRating = currentShieldRating;
            MaxShieldRating = maxShieldRating;
        }
            
    }
}
