namespace Ex05.GameLogic
{
    public class GameSettingsValidators
    {
        public static bool IsValidGridSize(int i_GridSize)
        {
            return i_GridSize >= Grid.k_MinGridSize && i_GridSize <= Grid.k_MaxGridSize;
        }
    }
}
