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
        public static SkillForm Instance;
        public SkillsFocus SkillFocusList { get; set; } = new SkillsFocus();
        public SkillsFocus SkillFocuses { get; }
        public SkillsTraining SkillTrainings { get; }


        public SkillForm(SkillsFocus skillFocuses, SkillsTraining skillTrainings)
        {
            
            InitializeComponent();
            Instance = this;
            SkillFocuses = skillFocuses;
            SkillTrainings = skillTrainings;
        }

        private void SkillForm_Load(object sender, EventArgs e)
        {
            //acrobaticsCheckBox.Checked = CharacterSheet.Instance.CharacterInfoSet.CharacterFocus.AcrobaticsFocus;
        }

        private void submitSkillsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //CharacterSheet.Instance.CharacterInfoSet.CharacterFocus.AcrobaticsFocus = acrobaticsCheckBox.Checked;
        }
    }
}
