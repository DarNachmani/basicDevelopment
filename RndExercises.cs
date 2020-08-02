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
}
