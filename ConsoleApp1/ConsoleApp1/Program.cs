
string str = "Roberto";
var firstName1=string.Empty;
var middleName1 = string.Empty;
var lastName1 = string.Empty;

SplitNameParts(true, str, ref firstName1, ref middleName1, ref lastName1);

Console.WriteLine(str);
Console.WriteLine($"first {firstName1}");
Console.WriteLine($"Middle {middleName1}");
Console.WriteLine($"Last {lastName1}");


void SplitNameParts(bool reverseName, string fullName, ref string firstName, ref string middleName, ref string lastName)
{
    CleanNames(ref firstName, ref middleName, ref lastName);
    string[] parts = fullName.Split(' ');
    List<string> partsList = new List<string>(parts);
    if (reverseName && fullName.Contains(","))
    {
        for (int i = 0; i <= partsList.Count - 1; i++)
        {
            if (partsList[0].Contains(","))
            {
                lastName += RemoveAll(partsList[0], ",") + " ";
                partsList.RemoveAt(0);
                break;
            }
            else
            {
                lastName += partsList[0] + " ";
                partsList.RemoveAt(0);
            }
        }
        lastName = lastName.TrimEnd();
        if (partsList.Count > 1)
        {
            middleName = partsList[partsList.Count - 1];
            partsList.RemoveAt(partsList.Count - 1);
        }
        firstName = string.Join(" ", partsList);
    }
    else
    {
        lastName = partsList[partsList.Count - 1];
        partsList.RemoveAt(partsList.Count - 1);
        if (partsList.Count > 1)
        {
            middleName = partsList[partsList.Count - 1];
            partsList.RemoveAt(partsList.Count - 1);
        }
        firstName = string.Join(" ", partsList);
    }
}

void CleanNames(ref string firstName, ref string middleName, ref string lastName)
{
    firstName = string.Empty;
    middleName = string.Empty;
    lastName = string.Empty;
}

string RemoveAll(string srcVal, string removeStr)
{
    return srcVal.Replace(removeStr, string.Empty);
}