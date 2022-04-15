using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaEditionMain_Desktop.Models.Character_Info
{
    public class CalculateHeroicLevel
    {
        public static int SetHeroicLevel(List<CharacterClasses.CharacterClassBase> classList)
        {
            int heroicLevel = 0;
            foreach (var characterClass in classList)
            {
                heroicLevel = heroicLevel + characterClass.Level;
            }
            return heroicLevel;
        }
    }
}
