using NUnit.Framework;
using MarsApp;
using MarsApp.Helpers;
using MarsApp.Entities;


namespace MarsApp_Testing
{
    public class Tests
    {
        MapBuilder map = new MapBuilder(3, 4);

        RoverEntity baseRover = new RoverEntity()
        {
            RoverID = 1,
            IsAlive = true,
            Or_Grade = 0,
            X_Position = 0,
            Y_Position = 0,
            Order = null
        };

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestIfOrientation()
        {


            RoverEntity rover = new RoverEntity()
            {
                RoverID = 1,
                IsAlive = true,
                Or_Grade =0,
                X_Position = 0,
                Y_Position = 0,
                Order = null
            };


            MovementOptions orders = new MovementOptions(rover, CompassEnum.Orientation.North, "L", map);
            orders.MoveTo();
            

            Assert.AreEqual(CompassEnum.Orientation.West, rover.Compass);
            Assert.AreEqual("L", rover.Order);
            Assert.AreEqual(0, rover.X_Position);
            Assert.AreEqual(0, rover.Y_Position);
            
        }
        [Test]
        public void TestIfMapOutside()
        {
            RoverEntity rover = new RoverEntity()
            {
                RoverID = 1,
                IsAlive = true,
                Or_Grade = 0,
                Compass = CompassEnum.Orientation.North,
                X_Position = 3,
                Y_Position = 4,
                Order = null
            };

            MovementOptions newOrders = new MovementOptions(rover, CompassEnum.Orientation.North, "F", map);
            newOrders.MoveTo();
            map.CheckIfRoverIs(rover);

            Assert.AreEqual(false, rover.IsAlive);
        }
        [Test]
        public void TestIfMove()
        {
            baseRover.Or_Grade = 90;
            MovementOptions newOrder = new MovementOptions(baseRover, CompassEnum.Orientation.East, "F", map);
            newOrder.MoveTo();

            Assert.AreEqual(CompassEnum.Orientation.East, baseRover.Compass);
            Assert.AreEqual("F", baseRover.Order);
            Assert.AreEqual(1, baseRover.X_Position);
            Assert.AreEqual(0, baseRover.Y_Position);
        }
        [Test]
        public void TestIfMultipleMoves()
        {
            RoverEntity baseRover = new RoverEntity()
            {
                RoverID = 1,
                IsAlive = true,
                Or_Grade = 0,
                X_Position = 0,
                Y_Position = 0,
                Order = null
            };
            string[] orders = { "F", "R", "L", "F" };
            foreach(string order in orders)
            {
                MovementOptions newOrder = new MovementOptions(baseRover, baseRover.Compass, order, map);
                newOrder.MoveTo();
            }

            Assert.AreEqual(0, baseRover.X_Position);
            Assert.AreEqual(2, baseRover.Y_Position);
        }
    }
}