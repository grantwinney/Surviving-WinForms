using MockingMessageBox;
using Moq;
using NUnit.Framework;

namespace MockingMessageBoxTests
{
    public class Tests
    {
        Form1 form;
        Mock<IMessagePrompt> messagePrompt;

        [SetUp]
        public void Setup()
        {
            messagePrompt = new Mock<IMessagePrompt>();
            form = new Form1(messagePrompt.Object);
        }

        [Test]
        public void Test1()
        {
            form.ShowBroadcastMessage();

            messagePrompt.Verify(x => x.Show(It.IsAny<string>(), "Fancy App"));
        }
    }
}