using NUnit.Framework;
using System.Collections.Generic;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class ListManagerTests
    {
        private ListManager manager;
        private List<int> numbers;

        [SetUp]
        public void Setup()
        {
            manager = new ListManager();
            numbers = new List<int>();
        }

        [Test]
        public void AddElement_Test()
        {
            manager.AddElement(numbers, 10);
            Assert.Contains(10, numbers);
        }

        [Test]
        public void RemoveElement_Test()
        {
            numbers.Add(5);
            manager.RemoveElement(numbers, 5);
            Assert.IsFalse(numbers.Contains(5));
        }

        [Test]
        public void GetSize_Test()
        {
            numbers.Add(1);
            numbers.Add(2);
            Assert.AreEqual(2, manager.GetSize(numbers));
        }
    }
}
