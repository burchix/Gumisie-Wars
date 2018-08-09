using System;
using NUnit.Framework;
using GummyBears.Common.Models;
using GummyBears.DTO.Models;
using AutoMapper;
using GummyBears.DAL.Mapper;
using System.Collections.Generic;
using GummyBears.Common.Enums;

namespace GummyBears.Tests
{
    [TestFixture]
    public class MapperTests
    {
        private IMapper _mapper;

        [OneTimeSetUp]
        public void Setup()
        {
            _mapper = new Mapper( new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }));
        }

        [Test]
        public void Mapper_User_To_UserDB()
        {
            //Arrange
            var user = new User()
            {
                Login = "login",
                Password = "password",
            };

            //Act
            var result = _mapper.Map<User, UserDB>(user);

            //Assert
            Assert.AreEqual(user.Login, result.Login);
            Assert.AreEqual(user.Password, result.Password);
        }

        [Test]
        public void Mapper_MapDB_To_Map()
        {
            //Arrange
            var mapDB = new MapDB()
            {
                Width = 2,
                Height = 2,
                CreateDate = DateTime.Now,
                Name = "Map",
                DefenceMultiplier = "1,0;1,0;1,0;1,0",
                JuiceMultiplier = "1,0;1,0;1,0;1,0",
                GoldMultiplier = "1,0;1,0;1,0;1,0",
                GummiesMultiplier = "1;1;1;1",
                GummiesNumber = "1;2;3;4",
                GummiesType = "0;1;2;0",
                Owner = "1;0;3;2"
            };

            //Act
            var map = _mapper.Map<MapDB, Map>(mapDB);

            //Assert
            Assert.AreEqual("Map", map.Name);
            Assert.AreEqual(GummyType.Magical, map.Fields[2].GummiesType);
            Assert.AreEqual(FieldOwner.Blocked, map.Fields[2].Owner);
        }
    }
}
