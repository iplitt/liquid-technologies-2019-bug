using System;
using LiquidTechnologies.Runtime.Standard20;
using Model;
using NUnit.Framework;

namespace ModelUnitTests
{
    [TestFixture]
    public class FromXmlTests
    {
        [Test]
        public void ToXml_GeneratesValidXml()
        {
            var car = new Car {Make = "VW", Color = "White", Owner = "Joe"};
            var xml = car.ToXml();
            Console.WriteLine(xml);
            Assert.That(xml, Is.Not.Null);
        }

        [Test]
        public void FromXml_AcceptsValidXml()
        {
            var xml = "<Car xmlns:xs=\"http://www.w3.org/2001/XMLSchema-instance\"><Make>VW</Make><Color>White</Color><Owner>Joe</Owner></Car>";
            var car = new Car();
            car.FromXml(xml);
            var newXml = car.ToXml();
            Console.WriteLine(newXml);
            Assert.That(car, Is.Not.Null);
        }

        [Test]
        public void FromXml_OmitsElementAfterAnUnknownElementIfUnknownElementIsPlacedBeforeTwoRemainingElements()
        {
            var xml = "<Car xmlns:xs=\"http://www.w3.org/2001/XMLSchema-instance\"><Make>VW</Make><abc>def</abc><Color>White</Color><Owner>Joe</Owner></Car>";
            var car = new Car();
            car.FromXml(xml, new SerializationContext { IgnoreUnknownElements = true, IgnoreUnknownAttributes = true });
            var newXml = car.ToXml();
            Console.WriteLine(newXml);
            Assert.That(car, Is.Not.Null);
        }

        [Test]
        public void FromXml_IgnoresUnknownElementIfPlacedBeforeTheLastElement()
        {
            var xml = "<Car xmlns:xs=\"http://www.w3.org/2001/XMLSchema-instance\"><Make>VW</Make><Color>White</Color><abc>def</abc><Owner>Joe</Owner></Car>";
            var car = new Car();
            car.FromXml(xml, new SerializationContext { IgnoreUnknownElements = true, IgnoreUnknownAttributes = true });
            var newXml = car.ToXml();
            Console.WriteLine(newXml);
            Assert.That(car, Is.Not.Null);
        }

    }
}