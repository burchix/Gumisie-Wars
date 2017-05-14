using GummyBears.Common.Enums;
using GummyBears.Common.Models;

namespace GummyBears.BLL.GameLogic
{
    public static class AILogic
    {
        // TODO: AI
        public static GameAction GenerateAction(Map map)
        {
            return new GameAction()
            {
                Action = ActionType.Void
            };
        }
    }
}
