using SagaEditionMain_Desktop.Models.Character_Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SagaEditionMain_Desktop
{
    public partial class SkillForm : Form
    {
        
        public SkillFocus SkillFocuses { get; set; } = new SkillFocus();
        public SkillsTraining SkillTrainings { get; set; }


        public SkillForm(SkillFocus skillFocuses, SkillsTraining skillTrainings)
        {
            
            InitializeComponent();
            SkillFocuses = skillFocuses;
            SkillTrainings = skillTrainings;
            LoadValues(SkillFocuses, SkillTrainings);
            
        }

        private void SkillForm_Load(object sender, EventArgs e)
        {
            //acrobaticsCheckBox.Checked = CharacterSheet.Instance.CharacterInfoSet.CharacterFocus.AcrobaticsFocus;
        }

        private void submitSkillsButton_Click(object sender, EventArgs e)
        {
            SkillFocuses = new SkillFocus();
            UpdateValues(SkillFocuses, SkillTrainings);
            CharacterSheet characterSheet = new CharacterSheet();
            characterSheet.ReceiveData(SkillFocuses, SkillTrainings);
            this.Close();
            //CharacterSheet.Instance.CharacterInfoSet.CharacterFocus.AcrobaticsFocus = acrobaticsCheckBox.Checked;
        }
        private void LoadValues(SkillFocus skillFocuses, SkillsTraining skillTrainings)
        {
            //Trainings
            acrobaticsTrainingCheckBox.Checked = SkillTrainings.AcrobaticsTraining;
            climbTrainingCheckBox.Checked = SkillTrainings.ClimbTraining;
            deceptionTrainingCheckBox.Checked = SkillTrainings.DeceptionTraining;
            enduranceTrainingCheckBox.Checked = SkillTrainings.EnduranceTraining;
            gatherInfoTrainingCheckBox.Checked = SkillTrainings.GatherInformationTraining;
            initiativeTrainingCheckBox.Checked = SkillTrainings.InitiativeTraining;
            jumpTrainingCheckBox.Checked = SkillTrainings.JumpTraining;
            bureaucracyTrainingCheckBox.Checked = SkillTrainings.KnowledgeBureaucracyTraining;
            galacticLoreTrainingCheckBox.Checked = SkillTrainings.KnowledgeGalacticLoreTraining;
            lifeSciencesTrainingCheckBox.Checked = SkillTrainings.KnowledgeLifeSciencesTraining;
            physicalSciencesTrainingCheckBox.Checked = SkillTrainings.KnowledgePhysicalSciencesTraining;
            socialSciencesTrainingCheckBox.Checked = SkillTrainings.KnowledgeSocialSciencesTraining;
            tacticsTrainingCheckBox.Checked = SkillTrainings.KnowledgeTacticsTraining;
            technologyTrainingCheckBox.Checked = SkillTrainings.KnowledgeTechnologyTraining;
            mechanicsTrainingCheckBox.Checked = SkillTrainings.MechanicsTraining;
            perceptionTrainingCheckBox.Checked = SkillTrainings.PerceptionTraining;
            persuasionTrainingCheckBox.Checked = SkillTrainings.PersuasionTraining;
            pilotTrainingCheckBox.Checked = SkillTrainings.PilotTraining;
            rideTrainingCheckBox.Checked = SkillTrainings.RideTraining;
            stealthTrainingCheckBox.Checked = SkillTrainings.StealthTraining;
            survivalTrainingCheckBox.Checked = SkillTrainings.SurvivalTraining;
            swimTrainingCheckBox.Checked = SkillTrainings.SwimTraining;
            treatInjuryTrainingCheckBox.Checked = SkillTrainings.TreatInjuryTraining;
            useComputerTrainingCheckBox.Checked = SkillTrainings.UseComputerTraining;
            useTheForceTrainingCheckBox.Checked = SkillTrainings.UseForceTraining;
            //Focuses
            acrobaticsFocusCheckBox.Checked = SkillFocuses.AcrobaticsFocus;
            climbFocusCheckBox.Checked = SkillFocuses.ClimbFocus;
            deceptionFocusCheckBox.Checked = SkillFocuses.DeceptionFocus;
            enduranceFocusCheckBox.Checked = SkillFocuses.EnduranceFocus;
            gatherInfoFocusCheckBox.Checked = SkillFocuses.GatherInformationFocus;
            initiativeFocusCheckBox.Checked = SkillFocuses.InitiativeFocus;
            jumpFocusCheckBox.Checked = SkillFocuses.JumpFocus;
            bureaucracyFocusCheckBox.Checked = SkillFocuses.KnowledgeBureaucracyFocus;
            galacticLoreFocusCheckBox.Checked = SkillFocuses.KnowledgeGalacticLoreFocus;
            lifeSciencesFocusCheckBox.Checked = SkillFocuses.KnowledgeLifeSciencesFocus;
            physicalSciencesFocusCheckBox.Checked = SkillFocuses.KnowledgePhysicalSciencesFocus;
            socialSciencesFocusCheckBox.Checked = SkillFocuses.KnowledgeSocialSciencesFocus;
            tacticsFocusCheckBox.Checked = SkillFocuses.KnowledgeTacticsFocus;
            technologyFocusCheckBox.Checked = SkillFocuses.KnowledgeTechnologyFocus;
            mechanicsFocusCheckBox.Checked = SkillFocuses.MechanicsFocus;
            perceptionFocusCheckBox.Checked = SkillFocuses.PerceptionFocus;
            persuasionFocusCheckBox.Checked = SkillFocuses.PersuasionFocus;
            pilotFocusCheckBox.Checked = SkillFocuses.PilotFocus;
            rideFocusCheckBox.Checked = SkillFocuses.RideFocus;
            stealthFocusCheckBox.Checked = SkillFocuses.StealthFocus;
            survivalFocusCheckBox.Checked = SkillFocuses.SurvivalFocus;
            swimFocusCheckBox.Checked = SkillFocuses.SwimFocus;
            treatInjuryFocusCheckBox.Checked = SkillFocuses.TreatInjuryFocus;
            useComputerFocusCheckBox.Checked = SkillFocuses.UseComputerFocus;
            useTheForceFocusCheckBox.Checked = SkillFocuses.UseForceFocus;
        }

        private void UpdateValues(SkillFocus skillFocuses, SkillsTraining skillTrainings)
        {
            //Trainings
            SkillTrainings.AcrobaticsTraining = acrobaticsTrainingCheckBox.Checked;
            SkillTrainings.ClimbTraining = climbTrainingCheckBox.Checked;
            SkillTrainings.DeceptionTraining = deceptionTrainingCheckBox.Checked;
            SkillTrainings.EnduranceTraining = enduranceTrainingCheckBox.Checked;
            SkillTrainings.GatherInformationTraining = gatherInfoTrainingCheckBox.Checked;
            SkillTrainings.InitiativeTraining = initiativeTrainingCheckBox.Checked;
            SkillTrainings.JumpTraining = jumpTrainingCheckBox.Checked;
            SkillTrainings.KnowledgeBureaucracyTraining = bureaucracyTrainingCheckBox.Checked;
            SkillTrainings.KnowledgeGalacticLoreTraining = galacticLoreTrainingCheckBox.Checked;
            SkillTrainings.KnowledgeLifeSciencesTraining = lifeSciencesTrainingCheckBox.Checked;
            SkillTrainings.KnowledgePhysicalSciencesTraining = physicalSciencesTrainingCheckBox.Checked;
            SkillTrainings.KnowledgeSocialSciencesTraining = socialSciencesTrainingCheckBox.Checked;
            SkillTrainings.KnowledgeTacticsTraining = tacticsTrainingCheckBox.Checked;
            SkillTrainings.KnowledgeTechnologyTraining = technologyTrainingCheckBox.Checked;
            SkillTrainings.MechanicsTraining = mechanicsTrainingCheckBox.Checked;
            SkillTrainings.PerceptionTraining = perceptionTrainingCheckBox.Checked;
            SkillTrainings.PersuasionTraining = persuasionTrainingCheckBox.Checked;
            SkillTrainings.PilotTraining = pilotTrainingCheckBox.Checked;
            SkillTrainings.RideTraining = rideTrainingCheckBox.Checked;
            SkillTrainings.StealthTraining = stealthTrainingCheckBox.Checked;
            SkillTrainings.SurvivalTraining = survivalTrainingCheckBox.Checked;
            SkillTrainings.SwimTraining = swimTrainingCheckBox.Checked;
            SkillTrainings.TreatInjuryTraining = treatInjuryTrainingCheckBox.Checked;
            SkillTrainings.UseComputerTraining = useComputerTrainingCheckBox.Checked;
            SkillTrainings.UseForceTraining = useTheForceTrainingCheckBox.Checked;
            //Focuses
            SkillFocuses.AcrobaticsFocus = acrobaticsFocusCheckBox.Checked;
            SkillFocuses.ClimbFocus = climbFocusCheckBox.Checked;
            SkillFocuses.DeceptionFocus = deceptionFocusCheckBox.Checked;
            SkillFocuses.EnduranceFocus = enduranceFocusCheckBox.Checked;
            SkillFocuses.GatherInformationFocus = gatherInfoFocusCheckBox.Checked;
            SkillFocuses.InitiativeFocus = initiativeFocusCheckBox.Checked;
            SkillFocuses.JumpFocus = jumpFocusCheckBox.Checked;
            SkillFocuses.KnowledgeBureaucracyFocus = bureaucracyFocusCheckBox.Checked;
            SkillFocuses.KnowledgeGalacticLoreFocus = galacticLoreFocusCheckBox.Checked;
            SkillFocuses.KnowledgeLifeSciencesFocus = lifeSciencesFocusCheckBox.Checked;
            SkillFocuses.KnowledgePhysicalSciencesFocus = physicalSciencesFocusCheckBox.Checked;
            SkillFocuses.KnowledgeSocialSciencesFocus = socialSciencesFocusCheckBox.Checked;
            SkillFocuses.KnowledgeTacticsFocus = tacticsFocusCheckBox.Checked;
            SkillFocuses.KnowledgeTechnologyFocus = technologyFocusCheckBox.Checked;
            SkillFocuses.MechanicsFocus = mechanicsFocusCheckBox.Checked;
            SkillFocuses.PerceptionFocus = perceptionFocusCheckBox.Checked;
            SkillFocuses.PersuasionFocus = persuasionFocusCheckBox.Checked;
            SkillFocuses.PilotFocus = pilotFocusCheckBox.Checked;
            SkillFocuses.RideFocus = rideFocusCheckBox.Checked;
            SkillFocuses.StealthFocus = stealthFocusCheckBox.Checked;
            SkillFocuses.SurvivalFocus = survivalFocusCheckBox.Checked;
            SkillFocuses.SwimFocus = swimFocusCheckBox.Checked;
            SkillFocuses.TreatInjuryFocus = treatInjuryFocusCheckBox.Checked;
            SkillFocuses.UseComputerFocus = useComputerFocusCheckBox.Checked;
            SkillFocuses.UseForceFocus = useTheForceFocusCheckBox.Checked;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
