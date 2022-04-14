using SagaEditionMain_Desktop.Models.Character_Info;
using SagaEditionMain_Desktop.Models.Character_Info.Attributes;
using SagaEditionMain_Desktop.Models.Die;

namespace SagaEditionMain_Desktop
{
    public partial class CharacterSheet : Form
    {
        public Species AllSpecies { get; set; } = new Species();
        public Species.SpeciesBase? SelectedSpecies { get; set; }
        public CharacterClasses AllClasses { get; set; } = new CharacterClasses();
        public CharacterClasses.CharacterClassBase? SelectedClass { get; set; }
        public int HeroicLevel { get; set; }
        public CharacterHealth CharacterHP { get; set; }
        public int FortMiscBonus { get; set; }
        public int RefMiscBonus { get; set; }
        public int WillMiscBonus { get; set; }
        public CharacterInfo? CharacterInfoSet { get; set; }
        static SkillFocus? SkillFocuses;
        static SkillsTraining? SkillTrainings;
        static Skills? SkillsList;
        public CharacterSheet()
        {
            //AllSpecies = new Species();
            //AllClasses = new CharacterClasses();
            SelectedClass = new CharacterClasses.CharacterClassBase();
            CharacterHP = new CharacterHealth(0,0,0,0,0,0);
            InitializeComponent();
        }

        internal void ReceiveData(SkillFocus skillFocuses, SkillsTraining skillTrainings)
        {
            SkillTrainings = skillTrainings;
            SkillFocuses = skillFocuses;
            this.UpdateSheet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SkillFocuses = new SkillFocus();
            SkillTrainings = new SkillsTraining();
            SkillsList = new Skills();
            speciesComboBox.DataSource = AllSpecies.SpeciesList;
            speciesComboBox.DisplayMember = "Name";
            classListComboBox.DataSource = AllClasses.ClassList;
            classListComboBox.DisplayMember = "Name";
            
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.UpdateSheet();

        }

        private void classListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedClass = classListComboBox.SelectedItem as CharacterClasses.CharacterClassBase;
                classLevelNumericUpDown.Value = SelectedClass.Level;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedClass = classListComboBox.SelectedItem as CharacterClasses.CharacterClassBase;
                SelectedClass.Level = Convert.ToInt32(classLevelNumericUpDown.Value);
                HeroicLevel = 0;
                string leveledClasses = "";
                foreach (var characterClass in AllClasses.ClassList)
                {
                    HeroicLevel = HeroicLevel + characterClass.Level;
                }
                heroicLevelNumericUpDown.Value = HeroicLevel;
                foreach (var possibleClass in AllClasses.ClassList)
                {
                    if (possibleClass.Level > 0)
                    {
                        leveledClasses = leveledClasses + " " + possibleClass.Name + " " + possibleClass.Level.ToString();
                    }

                }
                allLeveledClassesTextBox.Text = leveledClasses;
            }
            catch (Exception)
            {
                throw;
            }
            this.UpdateSheet();
        }

        private void fortificationDefenseBonusNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FortMiscBonus = Convert.ToInt32(fortificationDefenseBonusNumericUpDown.Value);
        }

        private void reflexDefenseBonusNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RefMiscBonus = Convert.ToInt32(reflexDefenseBonusNumericUpDown.Value);
        }

        private void willDefenseBonusNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            WillMiscBonus = Convert.ToInt32(willDefenseBonusNumericUpDown.Value);
        }

        private void lblDefenses_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(lblDefenses, "10 + Heroic Level + Attribute Mods + Bonuses");
        }

        private void addClassButton_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(addClassButton, "Click to set the level for a specific class.");
        }

        private void skillFocusAndTrainingButton_Click(object sender, EventArgs e)
        {
            var skillForm = new SkillForm(SkillFocuses, SkillTrainings);
            skillForm.ShowDialog();
        }

        private void damageThresholdBonusNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void damageThresholdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCondition_Click(object sender, EventArgs e)
        {

        }

        //private void btnRollDice_Click(object sender, EventArgs e)
        //{
        //    var die = new Die(20);
        //    int roll = die.roll();
        //    lblDiceRoll.Text = roll.ToString();
        //}
        internal void UpdateSheet()
        {
            int strScore = Convert.ToInt32(strengthScoreNumericUpDown.Value);
            int dexScore = Convert.ToInt32(dexterityScoreNumericUpDown.Value);
            int conScore = Convert.ToInt32(constitutionScoreNumericUpDown.Value);
            int intScore = Convert.ToInt32(intelligenceScoreNumericUpDown.Value);
            int wisScore = Convert.ToInt32(wisdomScoreNumericUpDown.Value);
            int chaScore = Convert.ToInt32(charismaScoreNumericUpDown.Value);
            FortMiscBonus = Convert.ToInt32(fortificationDefenseBonusNumericUpDown.Value);
            RefMiscBonus = Convert.ToInt32(reflexDefenseBonusNumericUpDown.Value);
            WillMiscBonus = Convert.ToInt32(willDefenseBonusNumericUpDown.Value);
            CharacterHP.CurrentHealth = Convert.ToInt32(currentHealthNumericUpDown.Value);
            CharacterHP.MaxHealth = Convert.ToInt32(maxHealthNumericUpDown.Value);
            CharacterHP.BonusHealth = Convert.ToInt32(bonusHPNumericUpDown.Value);
            CharacterHP.DamageReduction = Convert.ToInt32(damageReductionNumericUpDown.Value);
            CharacterHP.CurrentShieldRating = Convert.ToInt32(currentShieldRatingNumericUpDown.Value);
            CharacterHP.MaxShieldRating = Convert.ToInt32(maxShieldRatingNumericUpDown.Value);
            HeroicLevel = 0;

            foreach (var characterClass in AllClasses.ClassList)
            {
                HeroicLevel = HeroicLevel + characterClass.Level;
            }

            SelectedSpecies = speciesComboBox.SelectedItem as Species.SpeciesBase;

            var conditionTrack = new ConditionTrack(Convert.ToInt32(conditionNumericUpDown.Value));
            var characterAttributes = new CharacterAttributes(strScore, dexScore, conScore, intScore, wisScore, chaScore);
            var characterInputs = new CharacterInputs(SelectedSpecies, characterAttributes, CharacterHP, HeroicLevel, SkillFocuses, SkillTrainings, conditionTrack, FortMiscBonus, RefMiscBonus, WillMiscBonus);
            CharacterInfoSet = new CharacterInfo(characterInputs);
            //AttributeMods
            strengthModifierTextBox.Text = CharacterInfoSet.CharacterAttributeModifiers.StrengthModifier.ToString();
            dexterityModTextBox.Text = CharacterInfoSet.CharacterAttributeModifiers.DexterityModifier.ToString();
            constitutionModTextBox.Text = CharacterInfoSet.CharacterAttributeModifiers.ConstitutionModifier.ToString();
            intelligenceModTextBox.Text = CharacterInfoSet.CharacterAttributeModifiers.IntelligenceModifier.ToString();
            wisdomModTextBox.Text = CharacterInfoSet.CharacterAttributeModifiers.WisdomModifier.ToString();
            charismaModTextBox.Text = CharacterInfoSet.CharacterAttributeModifiers.CharismaModifier.ToString();
            fortDefenseTextBox.Text = CharacterInfoSet.CharacterDefenses.FortitudeDefense.ToString();
            refDefenseTextBox.Text = CharacterInfoSet.CharacterDefenses.ReflexDefense.ToString();
            willDefTextBox.Text = CharacterInfoSet.CharacterDefenses.WillDefense.ToString();

            //SkillValues
            acrobaticsTextBox.Text = CharacterInfoSet.CharacterSkills.AcrobaticsSkill.ToString();
            climbTextBox.Text = CharacterInfoSet.CharacterSkills.ClimbSkill.ToString();
            deceptionTextBox.Text = CharacterInfoSet.CharacterSkills.DeceptionSkill.ToString();
            enduranceTextBox.Text = CharacterInfoSet.CharacterSkills.EnduranceSkill.ToString();
            gatherInformationTextBox.Text = CharacterInfoSet.CharacterSkills.GatherInformationSkill.ToString();
            initiativeTextBox.Text = CharacterInfoSet.CharacterSkills.InitiativeSkill.ToString();
            jumpTextBox.Text = CharacterInfoSet.CharacterSkills.JumpSkill.ToString();
            knowledgeBureaucracyTextBox.Text = CharacterInfoSet.CharacterSkills.KnowledgeBureaucracySkill.ToString();
            knowledgeGalacticLoreTextBox.Text = CharacterInfoSet.CharacterSkills.KnowledgeGalacticLoreSkill.ToString();
            knowledgeLifeSciencesTextBox.Text = CharacterInfoSet.CharacterSkills.KnowledgeLifeSciencesSkill.ToString();
            knowledgePhysicalSciencesTextBox.Text = CharacterInfoSet.CharacterSkills.KnowledgePhysicalSciencesSkill.ToString();
            knowledgeSocialSciencesTextBox.Text = CharacterInfoSet.CharacterSkills.KnowledgeSocialSciencesSkill.ToString();
            knowledgeTacticsTextBox.Text = CharacterInfoSet.CharacterSkills.KnowledgeTacticsSkill.ToString();
            knowledgeTechnologyTextBox.Text = CharacterInfoSet.CharacterSkills.KnowledgeTechnologySkill.ToString();
            mechanicsTextBox.Text = CharacterInfoSet.CharacterSkills.KnowledgeTechnologySkill.ToString();
            perceptionTextBox.Text = CharacterInfoSet.CharacterSkills.PerceptionSkill.ToString();
            persuasionTextBox.Text = CharacterInfoSet.CharacterSkills.PersuasionSkill.ToString();
            pilotTextBox.Text = CharacterInfoSet.CharacterSkills.PersuasionSkill.ToString();
            rideTextBox.Text = CharacterInfoSet.CharacterSkills.RideSkill.ToString();
            stealthTextBox.Text = CharacterInfoSet.CharacterSkills.StealthSkill.ToString();
            survivalTextBox.Text = CharacterInfoSet.CharacterSkills.SurvivalSkill.ToString();
            swimTextBox.Text = CharacterInfoSet.CharacterSkills.SwimSkill.ToString();
            treatInjuryTextBox.Text = CharacterInfoSet.CharacterSkills.TreatInjurySkill.ToString();
            useComputerTextBox.Text = CharacterInfoSet.CharacterSkills.UseComputerSkill.ToString();
            useTheForceTextBox.Text = CharacterInfoSet.CharacterSkills.UseForceSkill.ToString();
        }
    }
}