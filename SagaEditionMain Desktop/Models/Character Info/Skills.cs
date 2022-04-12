using SagaEditionMain_Desktop.Models.Character_Info;
using SagaEditionMain_Desktop.Models.Character_Info.Attributes;
namespace SagaEditionMain_Desktop
{ 
    public class Skills
    {
        //public List<SkillBase> ListOfSkills;
        public int AcrobaticsSkill;//dex
        public int ClimbSkill;//str
        public int DeceptionSkill;//cha
        public int EnduranceSkill;//con
        public int GatherInformationSkill;//cha
        public int InitiativeSkill;//dex
        public int JumpSkill;//str
        public int KnowledgeBureaucracySkill;//dex
        public int KnowledgeGalacticLoreSkill;//dex
        public int KnowledgeLifeSciencesSkill;//dex
        public int KnowledgePhysicalSciencesSkill;//dex
        public int KnowledgeSocialSciencesSkill;//dex
        public int KnowledgeTacticsSkill;//dex
        public int KnowledgeTechnologySkill;//dex
        public int MechanicsSkill;//int
        public int PerceptionSkill;//wis
        public int PersuasionSkill;//cha
        public int PilotSkill;//dex
        public int RideSkill;//dex
        public int StealthSkill;//dex
        public int SurvivalSkill;//wis
        public int SwimSkill;//str
        public int TreatInjurySkill;//wis
        public int UseComputerSkill;//int
        public int UseForceSkill;//cha
        public Skills()
        {

        }
        public Skills(CharacterAttributeModifiers attributeModifiers, int heroicLevel, SkillsTraining training, SkillFocus focus)
        {
            AcrobaticsSkill = SetSkillBonuses(heroicLevel, AcrobaticsSkill, attributeModifiers.DexterityModifier, training.AcrobaticsTraining, focus.AcrobaticsFocus);
            ClimbSkill = SetSkillBonuses(heroicLevel, ClimbSkill, attributeModifiers.StrengthModifier, training.ClimbTraining, focus.ClimbFocus);
            DeceptionSkill = SetSkillBonuses(heroicLevel, DeceptionSkill, attributeModifiers.CharismaModifier, training.DeceptionTraining, focus.DeceptionFocus);
            EnduranceSkill = SetSkillBonuses(heroicLevel, EnduranceSkill, attributeModifiers.ConstitutionModifier, training.EnduranceTraining, focus.EnduranceFocus);
            GatherInformationSkill = SetSkillBonuses(heroicLevel, GatherInformationSkill, attributeModifiers.CharismaModifier, training.GatherInformationTraining, focus.GatherInformationFocus);
            InitiativeSkill = SetSkillBonuses(heroicLevel, InitiativeSkill, attributeModifiers.DexterityModifier, training.InitiativeTraining, focus.InitiativeFocus);
            JumpSkill = SetSkillBonuses(heroicLevel, JumpSkill, attributeModifiers.StrengthModifier, training.JumpTraining, focus.JumpFocus);
            KnowledgeBureaucracySkill = SetSkillBonuses(heroicLevel, KnowledgeBureaucracySkill, attributeModifiers.IntelligenceModifier, training.KnowledgeBureaucracyTraining, focus.KnowledgeBureaucracyFocus);
            KnowledgeGalacticLoreSkill = SetSkillBonuses(heroicLevel, KnowledgeGalacticLoreSkill, attributeModifiers.IntelligenceModifier, training.KnowledgeGalacticLoreTraining, focus.KnowledgeGalacticLoreFocus);
            KnowledgeLifeSciencesSkill = SetSkillBonuses(heroicLevel, KnowledgeLifeSciencesSkill, attributeModifiers.IntelligenceModifier, training.KnowledgeLifeSciencesTraining, focus.KnowledgeLifeSciencesFocus);
            KnowledgePhysicalSciencesSkill = SetSkillBonuses(heroicLevel, KnowledgePhysicalSciencesSkill, attributeModifiers.IntelligenceModifier, training.KnowledgePhysicalSciencesTraining, focus.KnowledgePhysicalSciencesFocus);
            KnowledgeSocialSciencesSkill = SetSkillBonuses(heroicLevel, KnowledgeSocialSciencesSkill, attributeModifiers.IntelligenceModifier, training.KnowledgeSocialSciencesTraining, focus.KnowledgeSocialSciencesFocus);
            KnowledgeTacticsSkill = SetSkillBonuses(heroicLevel, KnowledgeTacticsSkill, attributeModifiers.IntelligenceModifier, training.KnowledgeTacticsTraining, focus.KnowledgeTacticsFocus);
            KnowledgeTechnologySkill = SetSkillBonuses(heroicLevel, KnowledgeTechnologySkill, attributeModifiers.IntelligenceModifier, training.KnowledgeTechnologyTraining, focus.KnowledgeTechnologyFocus);
            MechanicsSkill = SetSkillBonuses(heroicLevel,MechanicsSkill, attributeModifiers.IntelligenceModifier, training.MechanicsTraining, focus.MechanicsFocus);
            PerceptionSkill = SetSkillBonuses(heroicLevel,PerceptionSkill, attributeModifiers.WisdomModifier, training.PerceptionTraining, focus.PerceptionFocus);
            PersuasionSkill = SetSkillBonuses(heroicLevel,PersuasionSkill, attributeModifiers.CharismaModifier, training.PersuasionTraining, focus.PersuasionFocus);
            PilotSkill = SetSkillBonuses(heroicLevel,PilotSkill,attributeModifiers.DexterityModifier, training.PilotTraining, focus.PilotFocus);
            RideSkill = SetSkillBonuses(heroicLevel,RideSkill,attributeModifiers.DexterityModifier, training.RideTraining, focus.RideFocus);
            StealthSkill = SetSkillBonuses(heroicLevel,StealthSkill,attributeModifiers.DexterityModifier, training.StealthTraining, focus.StealthFocus);
            SurvivalSkill = SetSkillBonuses(heroicLevel, SurvivalSkill, attributeModifiers.WisdomModifier, training.SurvivalTraining, focus.SurvivalFocus);
            SwimSkill = SetSkillBonuses(heroicLevel, SwimSkill, attributeModifiers.StrengthModifier, training.SwimTraining, focus.SwimFocus);
            TreatInjurySkill = SetSkillBonuses(heroicLevel, TreatInjurySkill, attributeModifiers.WisdomModifier, training.TreatInjuryTraining, focus.TreatInjuryFocus);
            UseComputerSkill = SetSkillBonuses(heroicLevel, UseComputerSkill, attributeModifiers.IntelligenceModifier, training.UseComputerTraining, focus.UseComputerFocus);
            UseForceSkill = SetSkillBonuses(heroicLevel, UseForceSkill, attributeModifiers.CharismaModifier, training.UseForceTraining, focus.UseForceFocus);

        }
        static int SetSkillBonuses(int heroicLevel, int skillBonusTotal, int attributeMod, bool training, bool focus)
        {
            skillBonusTotal = 0;
            skillBonusTotal = attributeMod + (heroicLevel / 2);
            if (training == true)
            {
                skillBonusTotal = skillBonusTotal + 5;
            }
            if (focus == true)
            {
                skillBonusTotal = skillBonusTotal + 5;
            }
            return skillBonusTotal;
        }
        
        //public Skills(int heroicLevel)
        //{
        //    List<SkillBase> skillList = new List<SkillBase>
        //    {
        //        new SkillBase
        //        {
        //            SkillName = "Acrobatics"
                    
        //        }
        //    };
        //}

        //public class SkillBase
        //{
        //    public string SkillName { get; set; }
        //    public int AttributeMod { get; set; }
        //    public int MiscBonus { get; set; }
        //    public bool Focus { get; set; }
        //    public bool Training { get; set; }

        //    //int skillBonusTotal = 0;
        //    //skillBonusTotal = attributeMod + (heroicLevel / 2);
        //    //if (training == true)
        //    //{
        //    //    skillBonusTotal = skillBonusTotal + 5;
        //    //}
        //    //if (focus == true)
        //    //{
        //    //    skillBonusTotal = skillBonusTotal + 5;
        //    //}
        //    //return skillBonusTotal;
        //}
    }
}
