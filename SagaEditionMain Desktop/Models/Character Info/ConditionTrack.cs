namespace SagaEditionMain_Desktop.Models.Character_Info
{
    public class ConditionTrack
    {
        public int ConditionTrackLevel;
        public int ConditionTrackPenalty;
        public ConditionTrack(int conditionTrackLevel)
        {
            ConditionTrackLevel = conditionTrackLevel;


            if (ConditionTrackLevel == -1)
            {
                ConditionTrackPenalty = -1;
            }
            else if (ConditionTrackLevel == -2)
            {
                ConditionTrackPenalty = -2;
            }
            else if (ConditionTrackLevel == -3)
            {
                ConditionTrackPenalty = -5;
            }
            else if (ConditionTrackLevel == -4)
            {
                ConditionTrackPenalty = -10;
            }
            else if (ConditionTrackLevel == -5)
            {
                ConditionTrackPenalty = -1000;
            }
            else
            {
                ConditionTrackPenalty = 0;
            }

        }
    }
}
