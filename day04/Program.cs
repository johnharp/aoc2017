string[] lines = File.ReadAllLines("input.txt");
int part1 = 0;

foreach(var line in lines)
{
    if (isValidPassphrase(line))
    {
        part1++;
    }
}

Console.WriteLine($"Part 1: {part1}");


bool isValidPassphrase(string line)
{
    string[] parts = line.Split(new [] { ' ', '\t'});
    HashSet<string> words = new HashSet<string>();

    foreach(var part in parts)
    {
        if (words.Contains(part))
        {
            return false;
        }
        else
        {
            words.Add(part);
        }
    }

    return true;
}