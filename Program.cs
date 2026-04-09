string[] citizen_names = new string [4];
citizen_names = ["Bruce Wayne","Clark Kent", "Arthur Curry", "Diana Prince"];

Console.WriteLine("Super Hero Identity Matcher");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Current citizens of interest: ");
for (int i = 0; i < citizen_names.Length; i++)
{
    Console.WriteLine($"\t{citizen_names[i]}");
    switch (citizen_names[i])
    {
        case ("Bruce Wayne"):
            citizen_names[i] = "Bruce Wayne - Batman";
            break;
        case ("Clark Kent"):
            citizen_names[i] = "Clark Kent - Superman";
            break;
        case ("Arthur Curry"):
            citizen_names[i] = "Arthur Curry - Aquaman";
            break;
        case ("Diana Prince"):
            citizen_names[i] = "Diana Prince - Wonder Woman";
            break;
    }
}
Console.WriteLine("\nSecret identity matching complete!");
Console.WriteLine("\nSuper Heros Identified:");
Console.WriteLine("-------------------------------------------");
foreach (string name in citizen_names)
{
    Console.WriteLine($"\t{name}");
}