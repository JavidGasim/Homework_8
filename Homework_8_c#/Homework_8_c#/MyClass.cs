namespace Homework8C;

internal class MyClass
{
    public delegate void MyDelegate(string str);

    public void Space(string str)
    {
        int indx = 0;
        int len = str.Length;
        char[] arr = new char[0];
        for (int i = 0; i < (len * 2) - 1; i += 2)
        {
            Array.Resize(ref arr, i+2);
            arr[i] = str[indx];

            if(indx == str.Length-1)
            {
                break;
            }

            arr[i+1] = '_';
            indx += 1;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }

        Console.WriteLine();
    }

    public void Reverse(string str)
    {
        char[] arr = new char[0];
        for (int i = 0; i < str.Length; i++)
        {
            Array.Resize(ref arr, i+2);
            arr[i] = str[i];
        }

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }
    }
}