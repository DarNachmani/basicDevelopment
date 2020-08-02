using System;

public class RndExercises
{
    public int CountOfCharInString(string s, char c)
    {
        int count = 0;
        var arr = s.ToCharArray();
        foreach(char chr in arr)
        {
            if(chr == c){
                count ++;
            }
        }
        return count;
    }

    public int LargestInArray(int[] arr)
    {
        int largest = arr[0];
        for(int i=1; i<arr.Length-1; i++){
            if(largest < arr[i]){
                largest = arr[i];
            }
        }
        return largest;
    }

    public bool ContainsDoubleDigit(int num)
    {
        int temp = 0;
        while(num > 0)
        {
            temp = num % 10;
            if(temp % 2 == 0)
            {
                return true;
            }
            num /= 10;
        }
    }

    public int ReversedNum(int num)
    {
        int temp = 0;
        int reversedNumber = 0;
        while(num > 0)
        {
            temp = num % 10;
            reversedNumber = reversedNumbern * 10 + temp;
            num /= 10;
        }
        return reversedNumber;
    }

    public int FirstRecursiveEx(int n)
    {
        if(n == 0)
        {
            return 2;
        }
        return 2*FirstRecursiveEx(n-1) + 3; 
    }

    public bool IsPolindrom(string str)
    {
        if (str.Length <= 1)
            return true;
        else
        {
            if ( str[0] != str[ text.Length - 1 ] )
                return false;
            else
                return IsPalindrome( str.Substring( 1, str.Length-2 ) );
        }   
    }

    public void WhenToUseEachLoop()
    {
        // I will use a for loop when I know the specific number of times the loop will happen.
        // I will use a while loop when I only know the condition I want the loop to happen in, but do not know the number of times it is going to happen.
    }

    public Dictionary<string, int> Ex5(List<string> strs)
    {
        Dictionary<string, int> countOfStrings = new Dictionary<string, int>();
        foreach(var str in strs)
        {
            if(countOfStrings.Keys.Contains(str))
            {
                countOfStrings[str] ++;
            }
            else
            {
                countOfStrings[str] = 1;
            }
        }
        return countOfStrings;
    }

    public void DifferenceBetweenMainElement(int[] arr)
    {
        int mainElement = 13;
        for(int i=0; i<arr.Length; i++)
        {
            if(i != mainElement)
            {
                Console.WriteLine(Math.Abs(mainElement - arr[i]));
            }
        }
    }

    public int OccuranceOfTatInStr(string str, string tat)
    {
        int index = 0;
        int i = 0;
        int count = 0;
        while(index != -1)
        {
            index = str.IndexOf(tat, i);
            i += tat.Length;
            count ++;
        }

        return count;
    }

    public int Metric(int[,] arr, int rowNum1, int rowNum2)
    {
        int sumOfFirstRow = 0;
        int sumOfSecondRow = 0;
        for(int i=0; i<arr.GetLength(1); i++)
        {
            sumOfFirstRow += arr[rowNum1, i];
            sumOfSecondRow += arr[rowNum2, i];
        }
        if(sumOfFirstRow == sumOfSecondRow)
        {
            return 1;
        }
        return 0;
    }

    public void BuildArray(int n)
    {
        var rnd = new Random();
        int countOfInputs = 0;
        int[] arr = new int[n];
        int doubleIndex = 0;
        int oddIndex = 1;
        while(countOfInputs < n)
        {
            rndNum = rnd.Next(10, 100);
            if(rndNum % 2 == 0)
            {
                if(doubleIndex < arr.Length - 2)
                {
                    arr[doubleIndex] = rndNum;
                    doubleIndex += 2;
                    countOfInputs ++;
                }
            }
            else
            {
                if(oddIndex < arr.Length - 2)
                {
                    arr[oddIndex] = rndNum;
                    oddIndex += 2;
                    countOfInputs ++;
                }
            }
        }
    }

    public int StringLengthEqualsToNum(string[] arr, int num)
    {
        int count = 0;
        foreach(var str in arr)
        {
            if(num == str.Length)
            {
                count ++;
            }
        }
        return count;
    }
}
