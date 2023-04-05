for (int i = 500; i >= 0; i--) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{i}");
    Console.ResetColor();
    Thread.Sleep(100);
}