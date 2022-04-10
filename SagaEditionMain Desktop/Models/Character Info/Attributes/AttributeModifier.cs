namespace SagaEditionMain_Desktop.Models.Character_Info.Attributes
{
    public static class AttributeModifier
    {
        public static int Modifier(int value, int conditionPenalty)
        {
            return ((value - 10) / 2) + conditionPenalty;
        }
    }
}
