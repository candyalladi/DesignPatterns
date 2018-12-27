namespace CommandPattern
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor garage;

        public GarageDoorOpenCommand(GarageDoor garage)
        {
            this.garage = garage;
        }

        public void Execute()
        {
            garage.LightOn();
        }
    }

    public class GarageDoorCloseCommand : ICommand
    {
        GarageDoor garage;

        public GarageDoorCloseCommand(GarageDoor garage)
        {
            this.garage = garage;
        }

        public void Execute()
        {
            garage.LightOff();
        }
    }
}
