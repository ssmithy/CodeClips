using FluentAssertions;

namespace Smithy.CodeClips.Test {
    [TestClass]
    public class TestTest {
        [TestMethod]
        public void TestHelloWorld() {
            Hello hello = new Hello();
            var test = hello.World();

            test.Should().Be("Hello, World!");
        }

        [TestMethod] 
        public void TestNotHelloWorld() {
            Hello hello = new Hello();
            var test = hello.World();

            test.Should().NotBe("Goodbye, World!");
        }
    }
}