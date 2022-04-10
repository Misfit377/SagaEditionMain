
using SagaEditionMain_Desktop.Models.Character_Info.Attributes;

namespace SagaEditionMain_Desktop.Models.Character_Info
{
    public class Defenses
    {
        public int FortitudeDefense;
        public int ReflexDefense;
        public int WillDefense;
        public Defenses(CharacterAttributeModifiers attributeModifiers, int heroicLevel)
        {
            FortitudeDefense = SetDefenses(attributeModifiers.ConstitutionModifier, heroicLevel);
            ReflexDefense = SetDefenses(attributeModifiers.DexterityModifier, heroicLevel);
            WillDefense = SetDefenses(attributeModifiers.WisdomModifier, heroicLevel);
        }
        static int SetDefenses(int attribute, int heroicLevel)
        {
            int value = 10;
            value = value + attribute + heroicLevel;

            return value;
        }
    }
}
