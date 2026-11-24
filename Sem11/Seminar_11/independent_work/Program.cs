using independent_work;

CommandLogger logger = new CommandLogger();
CommandReader.CommandEntered += logger.LogCommand;

ApplicationQuitter quitter = new ApplicationQuitter();
quitter.Connect();

CommandReader.CommandEntered += ShowHelp;

Monster monster1 = new Monster("Monster1", 30, 10);
Monster monster2 = new Monster("Monster2", 40, 15);

CombatSystem combatSystem = new CombatSystem();

CombatLogger combatLogger = new CombatLogger();
combatLogger.Connect(monster1);
combatLogger.Connect(monster2);

CommandReader.CommandEntered += command =>
{
    if (command == Commands.attack)
        combatSystem.Attack(monster1, monster2);

    if (command == Commands.status)
    {
        Console.WriteLine($"{monster1.Name}: {monster1.HP}/{monster1.MaxHP} HP");
        Console.WriteLine($"{monster2.Name}: {monster2.HP}/{monster2.MaxHP} HP");
    }
};

while (CommandReader.ReadCommand())
{
}

static void ShowHelp(Commands command)
{
    if (command != Commands.help)
        return;

    Console.WriteLine("Available commands: help, quit, attack, status");
}

