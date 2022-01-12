bool[] V1 = { false, true };
bool[] V2 = { false, true };
for (int i = 0; i < V1.Length; i++)
{
    for (int j = 0; j < V2.Length; j++)
    {
        Console.WriteLine($"{V1[i]} + {V2[j]} = {!(V1[i] && V2[j])} {(!V1[i] || !V2[j])}");
    }
}
