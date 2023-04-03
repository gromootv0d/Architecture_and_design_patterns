using CoolCar.Commands;
using CoolCar.Exceptions;
using CoolCar.Models;
using Moq;
using Xunit;

namespace CoolCar.Test
{
    public class MacroCommandTest
    {
        [Fact]
        public void MacroCommandTest_ShouldExucuteAllCommand_WhenGetValidCommands()
        {
            var command1 = new Mock<ICommand>();
            var command2 = new Mock<ICommand>();
            var commands = new ICommand[] { command1.Object, command2.Object };
            var macroCommand = new MacroCommand(commands);

            macroCommand.Execute();

            command1.Verify(command => command.Execute(), Times.Once);
            command2.Verify(command => command.Execute(), Times.Once);
        }

        [Fact]
        public void MacroCommandTest_ShouldThrowCommandException_WhenCatchException()
        {
            var command1 = new Mock<ICommand>();
            var command2 = new Mock<ICommand>();
            command2.Setup(c => c.Execute()).Throws<ArgumentNullException>();
            var commands = new ICommand[] { command1.Object, command2.Object };
            var macroCommand = new MacroCommand(commands);

            Assert.Throws<CommandException>(() => macroCommand.Execute());
        }
    }
}