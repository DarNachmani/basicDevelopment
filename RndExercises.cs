using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public enum Weather
{
    Winter = 1,
    Fall = 2,
    Spring = 3,
    Summer = 4
}
public class RndExercises
{
    public int CountOfCharInString(string s, char c)
    {
        int count = 0;
        var arr = s.ToCharArray();
        foreach (char chr in arr)
        {
            if (chr == c)
            {
                count++;
            }
        }
        return count;
    }

    public int LargestInArray(int[] arr)
    {
        int largest = arr[0];
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (largest < arr[i])
            {
                largest = arr[i];
            }
        }
        return largest;
    }

    public bool ContainsDoubleDigit(int num)
    {
        int temp = 0;
        while (num > 0)
        {
            temp = num % 10;
            if (temp % 2 == 0)
            {
                return true;
            }
            num /= 10;
        }
        return false;
    }

    public int ReversedNum(int num)
    {
        int temp = 0;
        int reversedNumber = 0;
        while (num > 0)
        {
            temp = num % 10;
            reversedNumber = reversedNumber * 10 + temp;
            num /= 10;
        }
        return reversedNumber;
    }

    public int FirstRecursiveEx(int n)
    {
        if (n == 0)
        {
            return 2;
        }
        return 2 * FirstRecursiveEx(n - 1) + 3;
    }

    public bool IsPalindrome(string str)
    {
        if (str.Length <= 1)
            return true;
        else
        {
            if (str[0] != str[str.Length - 1])
                return false;
            else
                return IsPalindrome(str.Substring(1, str.Length - 2));
        }
    }

    public List<int> ReverseListStack(List<int> lst)
    {
        Stack<int> stack = new Stack<int>();
        foreach (var elm in lst)
        {
            stack.Push(elm);
        }
        List<int> newList = new List<int>();
        foreach (var s in stack)
        {
            newList.Add(s);
        }

        return newList;
    }

    public List<int> ReverseListRecursive(List<int> lst, int first, int last)
    {
        if (last == first - 1)
        {
            return lst;
        }
        else
        {
            int temp = lst[first];
            lst[first] = lst[last];
            lst[last] = temp;
            return ReverseListRecursive(lst, first + 1, last - 1);
        }
    }

    public Dictionary<string, int> Ex5(List<string> strs)
    {
        Dictionary<string, int> countOfStrings = new Dictionary<string, int>();
        foreach (var str in strs)
        {
            if (countOfStrings.Keys.Contains(str))
            {
                countOfStrings[str]++;
            }
            else
            {
                countOfStrings[str] = 1;
            }
        }
        return countOfStrings;
    }

    public void SeasonOfTheYear(Weather w)
    {
        int i = (int)w;
        switch (i)
        {
            case 1:
                Console.WriteLine("Even though it is rainy outside, it is so hot");
                break;
            case 2:
                Console.WriteLine("The crunchy sound of the leaves is amazing");
                break;
            case 3:
                Console.WriteLine("The view is the best when the flowers are blooming");
                break;
            case 4:
                Console.WriteLine("It is so hot even the sun is sweating");
                break;
        }
    }

    public void DifferenceBetweenMainElement(int[] arr)
    {
        int mainElementIndex = 12;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i != mainElementIndex && i % 2 == 0)
            {
                Console.WriteLine(Math.Abs(arr[mainElementIndex] - arr[i]));
            }
        }
    }

    public int OccuranceOfTatInStr(string str, string tat)
    {
        int index = 0;
        int i = 0;
        int count = 0;
        while (index != -1)
        {
            index = str.IndexOf(tat, i);
            i += index + tat.Length;
            count++;
        }

        return count;
    }

    public int Metric(int[,] arr, int rowNum1, int rowNum2)
    {
        int sumOfFirstRow = 0;
        int sumOfSecondRow = 0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            sumOfFirstRow += arr[rowNum1, i];
            sumOfSecondRow += arr[rowNum2, i];
        }
        if (sumOfFirstRow == sumOfSecondRow)
        {
            return 1;
        }
        return 0;
    }

    public int[] BuildArray(int n)
    {
        var rnd = new Random();
        int countOfInputs = 0;
        int[] arr = new int[n];
        int doubleIndex = 0;
        int oddIndex = 1;
        int rndNum;
        while (countOfInputs < n)
        {
            rndNum = rnd.Next(10, 100);
            if (rndNum % 2 == 0)
            {
                if (doubleIndex < arr.Length - 2)
                {
                    arr[doubleIndex] = rndNum;
                    doubleIndex += 2;
                    countOfInputs++;
                }
                else if (arr.Length == 2 && doubleIndex == 0)
                {
                    arr[0] = rndNum;
                    countOfInputs++;
                    doubleIndex += 2;
                }
            }
            else
            {
                if (oddIndex < arr.Length - 2)
                {
                    arr[oddIndex] = rndNum;
                    oddIndex += 2;
                    countOfInputs++;
                }
                else if (arr.Length == 2)
                {
                    arr[1] = rndNum;
                    countOfInputs++;
                    oddIndex += 2;
                }
            }
        }
        return arr;
    }

    public int StringLengthEqualsToNum(string[] arr, int num)
    {
        int count = 0;
        foreach (var str in arr)
        {
            if (num == str.Length)
            {
                count++;
            }
        }
        return count;
    }
}
