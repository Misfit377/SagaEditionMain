using SagaEditionMain_Desktop.Models.Character_Info;
using SagaEditionMain_Desktop.Models.Character_Info.Attributes;
using SagaEditionMain_Desktop.Models.Die;

namespace SagaEditionMain_Desktop
{
    public partial class CharacterSheet : Form
    {
        public CharacterSheet()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int strScore = Convert.ToInt32(strengthScoreNumericUpDown.Value);
            int dexScore = Convert.ToInt32(dexterityScoreNumericUpDown.Value);
            int conScore = Convert.ToInt32(constitutionScoreNumericUpDown.Value);
            int intScore = Convert.ToInt32(intelligenceScoreNumericUpDown.Value);
            int wisScore = Convert.ToInt32(wisdomScoreNumericUpDown.Value);
            int chaScore = Convert.ToInt32(charismaScoreNumericUpDown.Value);
            int heroicLevel = Convert.ToInt32(heroicLevelNumericUpDown.Value);

            var conditionTrack = new ConditionTrack(Convert.ToInt32(conditionNumericUpDown.Value));
            var characterAttributes = new CharacterAttributes(strScore,dexScore,conScore,intScore,wisScore,chaScore);
            var skillsFocus = new SkillsFocus();
            var skillsTraining = new SkillsTraining();
            var characterInputs = new CharacterInputs(characterAttributes, heroicLevel, skillsFocus, skillsTraining,conditionTrack);
            var characterInfo = new CharacterInfo(characterInputs);
            strengthModifierTextBox.Text = characterInfo.CharacterAttributeModifiers.StrengthModifier.ToString();
            dexterityModTextBox.Text = characterInfo.CharacterAttributeModifiers.DexterityModifier.ToString();
            constitutionModTextBox.Text = characterInfo.CharacterAttributeModifiers.ConstitutionModifier.ToString();
            intelligenceModTextBox.Text = characterInfo.CharacterAttributeModifiers.IntelligenceModifier.ToString();
            wisdomModTextBox.Text = characterInfo.CharacterAttributeModifiers.WisdomModifier.ToString();  
            charismaModTextBox.Text = characterInfo.CharacterAttributeModifiers.CharismaModifier.ToString();
            fortDefenseTextBox.Text = characterInfo.CharacterDefenses.FortitudeDefense.ToString();
            refDefenseTextBox.Text = characterInfo.CharacterDefenses.ReflexDefense.ToString();
            willDefTextBox.Text = characterInfo.CharacterDefenses.WillDefense.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void btnRollDice_Click(object sender, EventArgs e)
        //{
        //    var die = new Die(20);
        //    int roll = die.roll();
        //    lblDiceRoll.Text = roll.ToString();
        //}
    }
}