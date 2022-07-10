Console.WriteLine("1.uc1-Finding Frequency in sentence\n2.uc2-Finding Frequency in paragragh\n3.uc3-Remove word\nEnter your choice:");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:

        Hash_Table.MyMapNode<int, string> hash = new Hash_Table.MyMapNode<int, string>(5);
        hash.add(0, "I");
        hash.add(1, "am");
        hash.add(2, "5");
        hash.add(3, "years");
        hash.add(4, "old");
        hash.add(5, "baby");
        hash.getFrequency("I");
        hash.getFrequency("am");
        hash.getFrequency("5");
        hash.getFrequency("years");
        break;
    case 2:
        string phrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
        string[] words = phrase.ToLower().Split(" ");
        var dist = words.Distinct();
        int length = 0;
        foreach (var word in dist)
            length++;
        Hash_Table.MyMapNode<string, int> map = new Hash_Table.MyMapNode<string, int>(length);
        int count = 1;
        foreach (string word in words)
        {
            if (map.ContainsKey(word))
            {
                count = map.GetValue(word) + 1;
                map.Remove(word);
                map.add(word, count);
            }
            else
            {
                map.add(word, 1);
            }
        }
        Console.WriteLine($"{"Frequency",20} | {"Count",10}\n");
        foreach (string key in dist)
        {
            Console.WriteLine($"{key,20} | {map.GetValue(key),10}");
        }
        break;
    case 3:
        string phrase1 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
        string[] words1 = phrase1.ToLower().Split(" ");
        var dist1 = words1.Distinct();
        int length1 = 0;
        foreach (var word in dist1)
            length1++;
        Hash_Table.MyMapNode<string, int> map1 = new Hash_Table.MyMapNode<string, int>(length1);
        int count1 = 1;
        foreach (string word in words1)
        {
            if (word == "avoidable")
            {
                continue;
            }
            else if (map1.ContainsKey(word))
            {
                count = map1.GetValue(word) + 1;
                map1.Remove(word);
                map1.add(word, count);
            }
            else
            {
                map1.add(word, 1);
            }
        }
        Console.WriteLine("Frequency-->Count");
        foreach (string key in dist1)
        {
            Console.WriteLine(key + "-->" + map1.GetValue(key));
        }
        break;
}
