using SagaEditionMain_Desktop.Models.Character_Info;
using SagaEditionMain_Desktop.Models.Character_Info.Attributes;
namespace SagaEditionMain_Desktop
{
    public class CharacterInputs
    {
        public CharacterAttributes CharacterAttributes;
        public SkillsFocus CharacterFocus;
        public SkillsTraining CharacterTraining;
        public ConditionTrack ConditionTrack;
        public int HeroicLevel;
        public Species.SpeciesBase SelectedSpecies { get; set; }

        public CharacterInputs(Species.SpeciesBase selectedSpecies, CharacterAttributes characterAttributes, int heroicLevel, SkillsFocus characterFocus, SkillsTraining characterTraining, ConditionTrack conditionTrack)
        {
            SelectedSpecies = selectedSpecies;
            CharacterAttributes = characterAttributes;
            CharacterFocus = new SkillsFocus();
            CharacterTraining = new SkillsTraining();
            ConditionTrack = conditionTrack;
            HeroicLevel = heroicLevel;
        }
    }
}
