Write("Введите элементы массива через пробел: ");
string elements = ReadLine();
int[] baseArray = GetArrayFromString(elements);

WriteLine(String.Join(" ", ResultArray(baseArray)));

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int[] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
    return result;
}