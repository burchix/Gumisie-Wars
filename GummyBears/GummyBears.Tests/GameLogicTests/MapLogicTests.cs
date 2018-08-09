using System;
using NUnit.Framework;
using GummyBears.Common.Models;
using GummyBears.Common.Enums;
using GummyBears.BLL.GameLogic;

namespace GummyBears.Tests.GameLogicTests
{
    [TestFixture]
    public class MapLogicTests
    {
        private Game _game;

        [SetUp]
        public void SetUp()
        {
            _game = PrepareGame();
        }

        [Test]
        public void Normalize_When_MoveToEmptyField_Then_ActionStateIsTrue()
        {
            //Arrange
            var action = new GameAction()
            {
                Field1 = 0,
                Field2 = 3,
                Action = ActionType.Move,
            };

            //Act
            var result = action.Normalize(_game);

            //Assert
            Assert.IsTrue(result.State);
        }

        [Test]
        public void Normalize_When_MoveToOwnerField_Then_ActionStateIsTrue()
        {
            //Arrange
            _game.Map.Fields[1].Owner = FieldOwner.Player;
            var action = new GameAction()
            {
                Field1 = 0,
                Field2 = 1,
                Action = ActionType.Move,
            };

            //Act
            var result = action.Normalize(_game);

            //Assert
            Assert.IsTrue(result.State);
        }

        [Test]
        public void Normalize_When_MoveToTakenFieldWithLessGummies_Then_ActionStateIsTrue()
        {
            //Arrange
            var action = new GameAction()
            {
                Field1 = 0,
                Field2 = 2,
                Action = ActionType.Move,
            };

            //Act
            var result = action.Normalize(_game);

            //Assert
            Assert.IsTrue(result.State);
        }

        [Test]
        public void Normalize_When_MoveToTakenFieldWithMoreGummies_Then_ActionStateIsFalse()
        {
            //Arrange
            _game.Map.Fields[2].GummiesNumber = _game.Map.Fields[0].GummiesNumber + 2;
            var action = new GameAction()
            {
                Field1 = 0,
                Field2 = 2,
                Action = ActionType.Move,
            };

            //Act
            var result = action.Normalize(_game);

            //Assert
            Assert.IsFalse(result.State);
        }

        [Test]
        public void Normalize_When_MoveWithJuiceToTakenFieldWithMoreGummiesButWin_Then_ActionStateIsTrue()
        {
            //Arrange
            var action = new GameAction()
            {
                Field1 = 0,
                Field2 = 2,
                Action = ActionType.MoveWithJuice,
            };

            //Act
            var result = action.Normalize(_game);

            //Assert
            Assert.IsTrue(result.State);
        }

        private Game PrepareGame()
        {
            return new Game()
            {
                Map = new Map()
                {
                    Height = 2,
                    Width = 2,
                    Fields = new Field[]
                    {
                        new Field()
                        {
                            Owner = FieldOwner.Player,
                            GummiesNumber = 10
                        },
                        new Field()
                        {
                            Owner = FieldOwner.Blocked
                        },
                        new Field()
                        {
                            Owner = FieldOwner.AI,
                            GummiesNumber = 9,
                            DefenceMultiplier = 1,
                        },
                        new Field()
                        {
                            Owner = FieldOwner.NoOne
                        }
                    }
                }
            };
        }
    }
}
