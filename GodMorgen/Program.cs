

Dictionary<string, List<string>> timeGreetings = new()
{
    ["morning"] = ["Good morning!  May your day be productive and joyful!",
    "Morning! Hope today brings you only good things.",
    "Good morning, sunshine! Smile and enjoy the day!",
    "Morning energy is ready for you! Start your day with a smile."
    ],
    ["aftenoon"] = ["Good afternoon! Hope your day is going smoothly.",
    "Afternoon! Keep up the great work and stay positive.",
    "Hello! Wishing you a productive and cheerful afternoon.",
    "Good afternoon! Take a short break and enjoy the moment."],
    ["evening"] = ["Good evening! Relax and enjoy your well-deserved rest.",
    "Evening! Hope your day ended on a positive note.",
    "Hello! Wishing you a calm and peaceful evening.",
    "Good evening! Time to unwind and recharge for tomorrow."],
    ["night"] = ["Good night! Sleep well and dream sweet dreams.",
    "Night! May your rest be deep and refreshing.",
    "Hello! Time to relax and let the day go.",
    "Good night! Prepare for a fresh start tomorrow."]
};

Dictionary<string, string> specialGreetings = new() { { "Albina", "Kjør på" } };
Random random = new();
void Run()
{
    while (true)
    {
        Console.WriteLine("Hello! Please enter your name (or 'exit' to quit):");
        string? name = Console.ReadLine();

        if (string.IsNullOrEmpty(name)) continue;
        if (name.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;
        Console.WriteLine(GetGreeting(name, DateTime.Now.Hour));

    }

}

string GetGreeting(string name, int hour)
{   Console.Clear();
    Console.WriteLine($"{name}, welcome to Good Morning app");
    foreach (var kvp in specialGreetings)
    {
        if (kvp.Key.Equals(name, StringComparison.OrdinalIgnoreCase)) return kvp.Value;
    }
    string period = hour switch
    {
        >= 5 and <= 12 => "morning",
        > 12 and <= 18 => "aftenoon",
        > 18 and <= 21 => "evening",
        _ => "night"
    };
    var message = timeGreetings[period];
    return message[random.Next(message.Count)];
}

Run();