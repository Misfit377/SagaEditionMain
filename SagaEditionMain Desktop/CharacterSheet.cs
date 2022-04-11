using SagaEditionMain_Desktop.Models.Character_Info;
using SagaEditionMain_Desktop.Models.Character_Info.Attributes;
using SagaEditionMain_Desktop.Models.Die;

namespace SagaEditionMain_Desktop
{
    public partial class CharacterSheet : Form
    {
        public Species AllSpecies { get; set; }
        public Species.SpeciesBase? SelectedSpecies { get; set; }
        public CharacterClasses AllClasses { get; set; }
        public CharacterClasses.CharacterClassBase? SelectedClass { get; set; }
        public int HeroicLevel { get; set; }
        public CharacterHealth CharacterHP { get; set; }
        public int FortMiscBonus { get; set; }
        public int RefMiscBonus { get; set; }
        public int WillMiscBonus { get; set; }
        public CharacterInfo CharacterInfoSet { get; set; }
        public CharacterSheet()
        {
            AllSpecies = new Species();
            AllClasses = new CharacterClasses();
            SelectedClass = new CharacterClasses.CharacterClassBase();
            CharacterHP = new CharacterHealth(0,0,0,0,0,0);
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            speciesComboBox.DataSource = AllSpecies.SpeciesList;
            speciesComboBox.DisplayMember = "Name";
            classListComboBox.DataSource = AllClasses.ClassList;
            classListComboBox.DisplayMember = "Name";
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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
            var characterAttributes = new CharacterAttributes(strScore,dexScore,conScore,intScore,wisScore,chaScore);
            var skillsFocus = new SkillsFocus();
            var skillsTraining = new SkillsTraining();
            var characterInputs = new CharacterInputs(SelectedSpecies, characterAttributes, CharacterHP, HeroicLevel, skillsFocus, skillsTraining,conditionTrack, FortMiscBonus, RefMiscBonus, WillMiscBonus);
            CharacterInfoSet = new CharacterInfo(characterInputs);
            strengthModifierTextBox.Text = CharacterInfoSet.CharacterAttributeModifiers.StrengthModifier.ToString();
            dexterityModTextBox.Text = CharacterInfoSet.CharacterAttributeModifiers.DexterityModifier.ToString();
            constitutionModTextBox.Text = CharacterInfoSet.CharacterAttributeModifiers.ConstitutionModifier.ToString();
            intelligenceModTextBox.Text = CharacterInfoSet.CharacterAttributeModifiers.IntelligenceModifier.ToString();
            wisdomModTextBox.Text = CharacterInfoSet.CharacterAttributeModifiers.WisdomModifier.ToString();  
            charismaModTextBox.Text = CharacterInfoSet.CharacterAttributeModifiers.CharismaModifier.ToString();
            fortDefenseTextBox.Text = CharacterInfoSet.CharacterDefenses.FortitudeDefense.ToString();
            refDefenseTextBox.Text = CharacterInfoSet.CharacterDefenses.ReflexDefense.ToString();
            willDefTextBox.Text = CharacterInfoSet.CharacterDefenses.WillDefense.ToString();

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

        //private void btnRollDice_Click(object sender, EventArgs e)
        //{
        //    var die = new Die(20);
        //    int roll = die.roll();
        //    lblDiceRoll.Text = roll.ToString();
        //}
    }
}