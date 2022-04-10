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
    public partial class ClassList : Form
    {
        public ClassList()
        {
            InitializeComponent();
        }

        private void submitClassesButton_Click(object sender, EventArgs e)
        {
            CharacterClasses characterClasses = new CharacterClasses();
            var classList = characterClasses.ClassList;
        }
    }
}
