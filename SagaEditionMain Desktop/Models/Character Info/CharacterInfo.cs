using SagaEditionMain_Desktop.Models.Character_Info.Attributes;

namespace SagaEditionMain_Desktop.Models.Character_Info
{
    public class CharacterInfo
    {
        public CharacterAttributes CharacterAttributes;
        public Skills CharacterSkills;
        public SkillsFocus CharacterFocus;
        public SkillsTraining CharacterTraining;
        public Defenses CharacterDefenses;
        public CharacterAttributeModifiers CharacterAttributeModifiers;
        // public CharacterInfo(Attributes characterAttributes, int heroicLevel)
        // {
        //     CharacterAttributes = characterAttributes;
        //     CharacterFocus = new SkillsFocus();
        //     CharacterTraining = new SkillsTraining();
        //     CharacterSkills = new Skills(CharacterAttributes, heroicLevel, CharacterTraining, CharacterFocus);
        // }       
        public CharacterInfo(CharacterInputs characterInputs)
        {
            CharacterAttributes = characterInputs.CharacterAttributes;
            CharacterAttributeModifiers = new CharacterAttributeModifiers(CharacterAttributes, characterInputs.ConditionTrack.ConditionTrackPenalty);
            CharacterFocus = characterInputs.CharacterFocus;
            CharacterTraining = characterInputs.CharacterTraining;
            CharacterSkills = new Skills(CharacterAttributeModifiers, characterInputs.HeroicLevel, CharacterTraining, CharacterFocus);
            CharacterDefenses = new Defenses(CharacterAttributeModifiers, characterInputs.HeroicLevel);
        }
    }
}
