
using SagaEditionMain_Desktop.Models.Character_Info.Attributes;

namespace SagaEditionMain_Desktop.Models.Character_Info
{
    public class Defenses
    {
        public int FortitudeDefense;
        public int ReflexDefense;
        public int WillDefense;
        public Defenses(CharacterAttributeModifiers attributeModifiers, int heroicLevel, int fortBonus, int refBonus, int willBonus)
        {
            FortitudeDefense = SetDefenses(attributeModifiers.ConstitutionModifier, heroicLevel, fortBonus);
            ReflexDefense = SetDefenses(attributeModifiers.DexterityModifier, heroicLevel, refBonus);
            WillDefense = SetDefenses(attributeModifiers.WisdomModifier, heroicLevel, willBonus);
        }
        static int SetDefenses(int attribute, int heroicLevel, int miscbonus)
        {
            int value = 0;
            int baseValue = 10;
            value = baseValue + attribute + heroicLevel + miscbonus;

            return value;
        }
    }
}
