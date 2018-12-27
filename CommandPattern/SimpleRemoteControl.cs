using System.Collections.Generic;

namespace CommandPattern
{
    public class SimpleRemoteControl
    {
        ICommand slot;

        public SimpleRemoteControl()
        {

        }

        public void SetCommand(ICommand command)
        {
            this.slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }

    public class RemoteControl
    {
        ICommand[] OnCommands;
        ICommand[] OffCommands;

        public RemoteControl()
        {
            OnCommands = new ICommand[7];
            OffCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                OnCommands[i] = noCommand;
                OffCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            OnCommands[slot].Execute();
        }

        public void OffButtonWasPressed(int slot)
        {
            OffCommands[slot].Execute();
        }
    }

    public class NoCommand : ICommand
    {
        public void Execute()
        {
            
        }
    }
}
