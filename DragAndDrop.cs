using NUnit.Framework;
using System;

namespace HerokuappExamples
{
    [TestFixture]
    public class DragAndDrop : BaseTest
    {
        internal DragAndDropPO DragAndDropPO { get; private set; } //Property for creating the DragAndDropPO in the setup

        [SetUp]
        public void ActionsRunBeforeEachTest()
        {
            DragAndDropPO = new DragAndDropPO(Driver);
            Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
        }

        [Test]
        public void DragAOnToB()
        {
            DragAndDropPO.DragAOverB();

           
        }
    }
}
