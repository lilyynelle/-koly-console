var tasks = new List<string>();
var running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("Správa úkolů");
    Console.WriteLine("1 - Přidat úkol");
    Console.WriteLine("2 - Vypsat úkoly");
    Console.WriteLine("0 - Konec");
    Console.Write("Vyberte možnost: ");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Zadejte úkol: ");
            var task = Console.ReadLine()?.Trim();

            if (!string.IsNullOrEmpty(task))
            {
                tasks.Add(task);
                Console.WriteLine("Úkol byl přidán.");
            }
            else
            {
                Console.WriteLine("Úkol nesmí být prázdný.");
            }
            break;

        case "2":
            if (tasks.Count == 0)
            {
                Console.WriteLine("Zatím nemáte žádné úkoly.");
                break;
            }

            for (var i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            break;

        case "0":
            running = false;
            break;

        default:
            Console.WriteLine("Neplatná volba.");
            break;
    }
}