using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaEditionMain_Desktop.Models.Character_Info.Attributes
{
    public class CharacterAttributeModifiers
    {
        public int StrengthModifier;
        public int DexterityModifier;
        public int ConstitutionModifier;
        public int IntelligenceModifier;
        public int WisdomModifier;
        public int CharismaModifier;
        public CharacterAttributeModifiers(CharacterAttributes characterAttribute, int conditionPenalty)
        {
            StrengthModifier = AttributeModifier.Modifier(characterAttribute.Strength, conditionPenalty);
            DexterityModifier = AttributeModifier.Modifier(characterAttribute.Dexterity, conditionPenalty);
            ConstitutionModifier = AttributeModifier.Modifier(characterAttribute.Constitution, conditionPenalty);
            IntelligenceModifier = AttributeModifier.Modifier(characterAttribute.Intelligence, conditionPenalty);
            WisdomModifier = AttributeModifier.Modifier(characterAttribute.Wisdom, conditionPenalty);
            CharismaModifier = AttributeModifier.Modifier(characterAttribute.Charisma, conditionPenalty);
        }
    }
}
