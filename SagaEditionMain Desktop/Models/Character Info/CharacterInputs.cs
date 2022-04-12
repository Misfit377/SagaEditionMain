using SagaEditionMain_Desktop.Models.Character_Info;
using SagaEditionMain_Desktop.Models.Character_Info.Attributes;
namespace SagaEditionMain_Desktop
{
    public class CharacterInputs
    {
        public CharacterAttributes CharacterAttributes;
        public SkillFocus CharacterFocus;
        public SkillsTraining CharacterTraining;
        public ConditionTrack ConditionTrack;
        public int HeroicLevel;
        public int FortMiscBonus;
        public int RefMiscBonus;
        public int WillMiscBonus;
        public Species.SpeciesBase? SelectedSpecies;
        public CharacterHealth CharacterHP;
        public CharacterInputs(Species.SpeciesBase? selectedSpecies, CharacterAttributes characterAttributes, CharacterHealth characterHP, int heroicLevel, SkillFocus characterFocus, SkillsTraining characterTraining, ConditionTrack conditionTrack, int fortMiscBonus, int refMiscBonus, int willMiscBonus)
        {
            CharacterHP = characterHP;
            SelectedSpecies = selectedSpecies;
            CharacterAttributes = characterAttributes;
            CharacterFocus = characterFocus;
            CharacterTraining = characterTraining;
            ConditionTrack = conditionTrack;
            HeroicLevel = heroicLevel;
            FortMiscBonus = fortMiscBonus;
            WillMiscBonus = willMiscBonus;
            RefMiscBonus = refMiscBonus;
        }
    }
}
