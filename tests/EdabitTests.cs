using static Edabit.Edabit;

namespace EdabitTests;

public class EdabitTests
{
    //boilerplate
    //[Fact]
    //public void Test()
    //{
    //    var actual = "";
    //    var expected = "";
    //    Assert.Equal(expected, Method(actual));
    //    var actual1 = "";
    //    var expected1 = "";
    //    Assert.Equal(expected1, Method(actual1));
    //    var actual2 = "";
    //    var expected2 = "";
    //    Assert.Equal(expected2, Method(actual2));
    //}

    //replaces all the vowels in a string with a specified character.

    [Fact]
    public void Test48()
    {
        var actuala = "the aardvark";
        var actualb = '#';
        var expected = "th# ##rdv#rk";
        Assert.Equal(expected, Method48(actuala, actualb));
        var actual1a = "minnie mouse";
        var actual1b = '?';
        var expected1 = "m?nn?? m??s?";
        Assert.Equal(expected1, Method48(actual1a, actual1b));
        var actual2a = "shakespeare";
        var actual2b = '*';
        var expected2 = "sh*k*sp**r*";
        Assert.Equal(expected2, Method48(actual2a, actual2b));
    }
    //checks whether a given string is a palindrome or not

    [Fact]
    public void Test47()
    {
        var actual = "mom";
        var expected = true;
        Assert.Equal(expected, Method47(actual));
        var actual1 = "scary";
        var expected1 = false;
        Assert.Equal(expected1, Method47(actual1));
        var actual2 = "reviver";
        var expected2 = true;
        Assert.Equal(expected2, Method47(actual2));
        var actual3 = "stressed";
        var expected3 = false;
        Assert.Equal(expected3, Method47(actual3));
    }
    //returns a string in the form of an anonymous type that shows the count of numbers or letters in a given string

    [Fact]
    public void Test46()
    {
        var actual = "Hello World";
        var expected = "{ LETTERS =  10, DIGITS =  0 }";
        Assert.Equal(expected, Method46(actual));
        var actual1 = "H3ll0 Wor1d";
        var expected1 = "{ LETTERS =  7, DIGITS =  3 }";
        Assert.Equal(expected1, Method46(actual1));
        var actual2 = "149990";
        var expected2 = "{ LETTERS =  0, DIGITS =  6 }";
        Assert.Equal(expected2, Method46(actual2));
    }
    //retrieves the name of the subreddit from a reddit URL

    [Fact]
    public void Test45()
    {
        var actual = "https://www.reddit.com/r/funny/";
        var expected = "funny";
        Assert.Equal(expected, Method45(actual));
        var actual1 = "https://www.reddit.com/r/relationships/";
        var expected1 = "relationships";
        Assert.Equal(expected1, Method45(actual1));
        var actual2 = "https://www.reddit.com/r/mildlyinteresting/";
        var expected2 = "mildlyinteresting";
        Assert.Equal(expected2, Method45(actual2));
    }
    //takes 3 numbers: a, b, c and returns true if the last digit of a * b = the last digit of c.

    [Fact]
    public void Test44()
    {
        var actuala = 25;
        var actualb = 21;
        var actualc = 125;
        var expected = true;
        Assert.Equal(expected, Method44(actuala, actualb, actualc));
        var actual1a = 55;
        var actual1b = 226;
        var actual1c = 5190;
        var expected1 = true;
        Assert.Equal(expected1, Method44(actual1a, actual1b, actual1c));
        var actual2a = 12;
        var actual2b = 215;
        var actual2c = 2142;
        var expected2 = false;
        Assert.Equal(expected2, Method44(actual2a, actual2b, actual2c));
    }
    //takes a string and returns a string with its letters in alphabetical order.

    [Fact]
    public void Test43()
    {
        var actual = "hello";
        var expected = "ehllo";
        Assert.Equal(expected, Method43(actual));
        var actual1 = "edabit";
        var expected1 = "abdeit";
        Assert.Equal(expected1, Method43(actual1));
        var actual2 = "hacker";
        var expected2 = "acehkr";
        Assert.Equal(expected2, Method43(actual2));
        var actual3 = "geek";
        var expected3 = "eegk";
        Assert.Equal(expected3, Method43(actual3));
        var actual4 = "javascript";
        var expected4 = "aacijprstv";
        Assert.Equal(expected4, Method43(actual4));
    }
    //repeats each character in a string n times

    [Fact]
    public void Test42()
    {
        var actual = "mice";
        var num = 5;
        var expected = "mmmmmiiiiiccccceeeee";
        Assert.Equal(expected, Method42(actual, num));
        var actual1 = "hello";
        var num1 = 3;
        var expected1 = "hhheeellllllooo";
        Assert.Equal(expected1, Method42(actual1, num1));
        var actual2 = "stop";
        var num2 = 1;
        var expected2 = "stop";
        Assert.Equal(expected2, Method42(actual2, num2));
    }
    //takes an array of numbers and return both the minimum and maximum numbers, in that order.
    [Fact]
    public void Test41()
    {
        var actual = new[] { 1, 2, 3, 4, 5 };
        var expected = new[] { 1, 5 };
        Assert.Equal(expected, Method41(actual));
        var actual1 = new[] { 2334454, 5 };
        var expected1 = new[] { 5, 2334454 };
        Assert.Equal(expected1, Method41(actual1));
        var actual2 = new[] { 1 };
        var expected2 = new[] { 1, 1 };
        Assert.Equal(expected2, Method41(actual2));
    }
    /// <summary>
    /// Takes three string arguments (first, last, and word) and returns true if word is found between first and last in the dictionary, otherwise false.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>

    [Fact]
    public void Test40()
    {
        var actuala = "apple";
        var actualb = "banana";
        var actualc = "azure";
        var expected = true;
        Assert.Equal(expected, Method40(actuala, actualb, actualc));
        var actual1a = "monk";
        var actual1b = "monument";
        var actual1c = "monkey";
        var expected1 = true;
        Assert.Equal(expected1, Method40(actual1a, actual1b, actual1c));
        var actual2a = "bookend";
        var actual2b = "boolean";
        var actual2c = "boost";
        var expected2 = false;
        Assert.Equal(expected2, Method40(actual2a, actual2b, actual2c));
    }
    /// <summary>
    /// makes the last character of a string repeat n number of times
    /// </summary>
    /// <param name="s"></param>
    /// <param name="a"></param>
    /// <returns></returns>
    [Fact]
    public void Test39()
    {
        var actual = "Hello";
        var actuala = 3;
        var expected = "Hellooo";
        Assert.Equal(expected, Method39(actual, actuala));
        var actual1 = "hey";
        var actualb = 6;
        var expected1 = "heyyyyyy";
        Assert.Equal(expected1, Method39(actual1, actualb));
        var actual2 = "excuse me what?";
        var actualc = 5;
        var expected2 = "excuse me what?????";
        Assert.Equal(expected2, Method39(actual2, actualc));
    }
    /// <summary>
    /// Returns the average of an array
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>

    [Fact]
    public void Test38()
    {
        var actual = new[] { 1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3 };
        var expected = 2.55;
        Assert.Equal(expected, Method38(actual));
        var actual1 = new[] { 2, 3, 2, 3 };
        var expected1 = 2.50;
        Assert.Equal(expected1, Method38(actual1));
        var actual2 = new[] { 3, 3, 3, 3, 3 };
        var expected2 = 3.00;
        Assert.Equal(expected2, Method38(actual2));
    }
    /// <summary>
    /// Finds the factorial of a given number using recursion
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>

    [Fact]
    public void Test37()
    {
        var actual = 5;
        var expected = 120;
        Assert.Equal(expected, Method37(actual));
        var actual1 = 3;
        var expected1 = 6;
        Assert.Equal(expected1, Method37(actual1));
        var actual2 = 2;
        var expected2 = 2;
        Assert.Equal(expected2, Method37(actual2));
    }
    /// <summary>
    ///  Takes a string and returns a string with spaces in between all of the characters.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>

    [Fact]
    public void Test36()
    {
        var actual = "space";
        var expected = "s p a c e";
        Assert.Equal(expected, Method36(actual));
        var actual1 = "far out";
        var expected1 = "f a r   o u t";
        Assert.Equal(expected1, Method36(actual1));
        var actual2 = "elongated musk";
        var expected2 = "e l o n g a t e d   m u s k";
        Assert.Equal(expected2, Method36(actual2));
    }
    /// <summary>
    /// Takes an array of 10 numbers (between 0 and 9) and returns a string of those numbers formatted as a phone number (e.g. (555) 555-5555).
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>

    [Fact]
    public void Test35()
    {
        var actual = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        var expected = "(123) 456-7890";
        Assert.Equal(expected, Method35(actual));
        var actual1 = new[] { 5, 1, 9, 5, 5, 5, 4, 4, 6, 8 };
        var expected1 = "(519) 555-4468";
        Assert.Equal(expected1, Method35(actual1));
        var actual2 = new[] { 3, 4, 5, 5, 0, 1, 2, 5, 2, 7 };
        var expected2 = "(345) 501-2527";
        Assert.Equal(expected2, Method35(actual2));
    }
    /// <summary>
    /// Stutters a word as if someone is struggling to read it.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>

    [Fact]
    public void Test34()
    {
        var actual = "incredible";
        var expected = "in... in... incredible?";
        Assert.Equal(expected, Method34(actual));
        var actual1 = "enthusiastic";
        var expected1 = "en... en... enthusiastic?";
        Assert.Equal(expected1, Method34(actual1));
        var actual2 = "outstanding";
        var expected2 = "ou... ou... outstanding?";
        Assert.Equal(expected2, Method34(actual2));
    }

    /// <summary>
    /// Adds two words together and capatilize the first letter
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>

    [Fact]
    public void Test33()
    {
        var actuala = "seas";
        var actualb = "onal";
        var expected = "Seasonal";
        Assert.Equal(expected, Method33(actuala, actualb));
        var actuala1 = "comp";
        var actualb1 = "lete";
        var expected1 = "Complete";
        Assert.Equal(expected1, Method33(actuala1, actualb1));
        var actuala2 = "lang";
        var actualb2 = "uage";
        var expected2 = "Language";
        Assert.Equal(expected2, Method33b(actuala2, actualb2));
        var actuala3 = "mitc";
        var actualb3 = "hell";
        var expected3 = "Mitchell";
        Assert.Equal(expected3, Method33c(actuala3, actualb3));
    }
    /// <summary>
    /// Takes a word and returns true if the word has two consecutive identical letters.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>

    [Fact]
    public void Test32()
    {
        var actual = "loop";
        var actual1 = "yummy";
        var actual2 = "orange";
        var actual3 = "munchkin";
        Assert.True(Method32(actual));
        Assert.True(Method32(actual1));
        Assert.False(Method32(actual2));
        Assert.False(Method32(actual3));

    }
    /// <summary>
    /// Takes a string, checks if it has the same number of x's and o's and returns either true or false.
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test31()
    {
        var actual = "ooxx";
        Assert.True(Method31(actual));
        var actual1 = "xooxx";
        Assert.False(Method31(actual1));
        var actual2 = "ooxXm";
        Assert.True(Method31(actual2));
        var actual3 = "zpzpzpp";
        Assert.True(Method31(actual3));
    }
    /// <summary>
    /// Takes an array of strings and returns the words that are exactly four letters.
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test30()
    {
        var actual = new[] { "Tomato", "Potato", "Pair" };
        var expected = new[] { "Pair" };
        Assert.Equal(expected, Method30(actual));
        var actual1 = new[] { "Kangaroo", "Bear", "Fox" };
        var expected1 = new[] { "Bear" };
        Assert.Equal(expected1, Method30(actual1));
        var actual2 = new[] { "Ryan", "Kieran", "Jason", "Matt" };
        var expected2 = new[] { "Ryan", "Matt" };
        Assert.Equal(expected2, Method30(actual2));
    }
    /// <summary>
    /// returns the next number greater than a and b and divisible by b. A will always be greater than b.
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test29()
    {
        var actual = 17;
        var actualb = 8;
        var expected = 24;
        Assert.Equal(expected, Method29(actual, actualb));
        var actual1 = 98;
        var actualb1 = 3;
        var expected1 = 99;
        Assert.Equal(expected1, Method29(actual1, actualb1));
        var actual2 = 14;
        var actualb2 = 11;
        var expected2 = 22;
        Assert.Equal(expected2, Method29(actual2, actualb2));
    }
    /// <summary>
    /// Recursively finds the sum of the first n natural numbers.
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test28()
    {
        var actual = 5;
        var expected = 15;
        Assert.Equal(expected, Method28(actual));
        var actual2 = 1;
        var expected2 = 1;
        Assert.Equal(expected2, Method28(actual2));
        var actual3 = 12;
        var expected3 = 78;
        Assert.Equal(expected3, Method28(actual3));
    }
    /// <summary>
    /// Takes a number and returns that given number of Rs in the word Burp
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test27()
    {
        var actual = 3;
        var expected = "Burrrp";
        Assert.Equal(expected, Method27(actual));
        var actual2 = 5;
        var expected2 = "Burrrrrp";
        Assert.Equal(expected2, Method27(actual2));
        var actual3 = 9;
        var expected3 = "Burrrrrrrrrp";
        Assert.Equal(expected3, Method27(actual3));
    }
    /// <summary>
    ///  Takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.
    /// </summary>
    /// <returns>In order to work properly, the function should replace all "a"s with 4, "e"s with 3, "i"s with 1, "o"s with 0, and "s"s with 5.</returns>

    [Fact]
    public void Test26()
    {
        var actual = "javascript is cool";
        var expected = "j4v45cr1pt 15 c00l";
        Assert.Equal(expected, Method26(actual));
        var actual1 = "programming is fun";
        var expected1 = "pr0gr4mm1ng 15 fun";
        Assert.Equal(expected1, Method26(actual1));
        var actual2 = "become a coder";
        var expected2 = "b3c0m3 4 c0d3r";
        Assert.Equal(expected2, Method26(actual2));
    }
    /// <summary>
    /// Returns the number of hashes and pluses in a string
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test25()
    {
        var actual = "###+";
        var expected = new[] { 3, 1 };
        Assert.Equal(expected, Method25(actual));
        var actual1 = "##+++#";
        var expected1 = new[] { 3, 3 };
        Assert.Equal(expected1, Method25(actual1));
        var actual2 = "#+++#+#++#";
        var expected2 = new[] { 4, 6 };
        Assert.Equal(expected2, Method25(actual2));
    }
    /// <summary>
    /// Takes an array of numbers and returns only the even values
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test24()
    {
        var actual = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        var expected = new int[] { 2, 4, 6, 8 };
        Assert.Equal(expected, Method24(actual));
        var actual1 = new int[] { 43, 65, 23, 89, 53, 9, 6 };
        var expected1 = new int[] { 6 };
        Assert.Equal(expected1, Method24(actual1));
        var actual2 = new int[] { 718, 991, 449, 644, 380, 440 };
        var expected2 = new int[] { 718, 644, 380, 440 };
        Assert.Equal(expected2, Method24(actual2));
    }
    /// <summary>
    /// Takes in two numbers and returns the percentage of the first over the second
    /// </summary>
    /// <returns></returns>
    [Fact]
    public void Test23()
    {
        var actuala = 1;
        var actualb = 10;
        var expected = "10%";
        Assert.Equal(expected, Method23(actuala, actualb));
        var actual1a = 2;
        var actual1b = 5;
        var expected1 = "40%";
        Assert.Equal(expected1, Method23(actual1a, actual1b));
        var actual2a = 1;
        var actual2b = 8;
        var expected2 = "13%";
        Assert.Equal(expected2, Method23(actual2a, actual2b));
    }
    /// <summary>
    /// Take an array and return an array with the same numbers sorted from lowest to highest
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test22()
    {
        var actual = new int[] { 1, 2, 10, 50, 5 };
        var expected = new int[] { 1, 2, 5, 10, 50 };
        Assert.Equal(expected, Method22(actual));
        var actual2 = new int[] { 80, 29, 4, -95, -24, 85 };
        var expected2 = new int[] { -95, -24, 4, 29, 80, 85 };
        Assert.Equal(expected2, Method22(actual2));
        var actual3 = Array.Empty<int>();
        var expected3 = Array.Empty<int>();
        Assert.Equal(expected3, Method22(actual3));
    }
    /// <summary>
    /// Takes a number and returns the name of a shape with that many sides.
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test21()
    {
        var actual = 3;
        var expected = "triangle";
        Assert.Equal(expected, Method21(actual));
        var actual2 = 1;
        var expected2 = "circle";
        Assert.Equal(expected2, Method21(actual2));
        var actual3 = 9;
        var expected3 = "nonagon";
        Assert.Equal(expected3, Method21(actual3));
    }
    /// <summary>
    /// Takes a string and returns it in reverse
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test20()
    {
        var actual = "Hello World";
        var expected = "dlroW olleH";
        Assert.Equal(expected, Method20(actual));
        var actual2 = "The quick brown fox.";
        var expected2 = ".xof nworb kciuq ehT";
        Assert.Equal(expected2, Method20(actual2));
        var actual3 = "Edabit is really helpful!";
        var expected3 = "!lufpleh yllaer si tibadE";
        Assert.Equal(expected3, Method20b(actual3));
    }
    /// <summary>
    /// Takes a string and a number and returns a string repeated n number of times
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test19()
    {
        var actual = "ab";
        var actualNum = 3;
        var expected = "ababab";
        Assert.Equal(expected, Method19(actual, actualNum));
        var actual2 = "kiwi";
        var actualNum2 = 1;
        var expected2 = "kiwi";
        Assert.Equal(expected2, Method19(actual2, actualNum2));
        var actual3 = "cherry";
        var actualNum3 = 4;
        var expected3 = "cherrycherrycherrycherry";
        Assert.Equal(expected3, Method19(actual3, actualNum3));
    }
    /// <summary>
    /// Returns the selected filename from a path. Include the extension in your answer.
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test18()
    {
        Assert.Equal("txt", Method18("C:/Projects/pil_tests/ascii/txt"));
        Assert.Equal("Beethoven_5.mp3", Method18("C:/Users/johnsmith/Music/Beethoven_5.mp3"));
        Assert.Equal("ffprobe.exe", Method18("ffprobe.exe"));
    }
    /// <summary>
    ///  Takes an integer and returns the factorial of that integer. That is, the integer multiplied by all positive lower integers.
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test17()
    {
        Assert.Equal(6, Method17(3));
        Assert.Equal(120, Method17(5));
        Assert.Equal(6227020800, Method17(13));
        Assert.Equal(0, Method17b(-5));
    }
    /// <summary>
    /// Multiplies all of the values in an array by the amount of values in the given array.
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test16()
    {
        int[] actual1 = new int[4] { 2, 3, 1, 0 };
        int[] expected1 = new int[4] { 8, 12, 4, 0 };
        Assert.Equal(expected1, Method16(actual1));
        int[] actual2 = new int[3] { 4, 1, 1 };
        int[] expected2 = new int[3] { 12, 3, 3 };
        Assert.Equal(expected2, Method16(actual2));
        int[] actual3 = new int[7] { 1, 0, 3, 3, 7, 2, 1 };
        int[] expected3 = new int[7] { 7, 0, 21, 21, 49, 14, 7 };
        Assert.Equal(expected3, Method16(actual3));
        int[] actual4 = new int[1] { 0 };
        int[] expected4 = new int[1] { 0 };
        Assert.Equal(expected4, Method16(actual4));
    }

    /// <summary>
    /// takes a base number and an exponent number and returns the calculation.
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test15()
    {
        Assert.Equal(3125, Method15(5, 5));
        Assert.Equal(10000000000, Method15(10, 10));
        Assert.Equal(27, Method15(3, 3));
    }
    /// <summary>
    /// Takes a string and returns the number (count) of vowels contained within it.
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test14()
    {
        Assert.Equal(5, Method14("Celebration"));
        Assert.Equal(1, Method14("Palm"));
        Assert.Equal(4, Method14("Prediction"));
        Assert.Equal(3, Method14b("Mitchell Scott"));
    }
    /// <summary>
    /// Takes a string and returns a string in which each character is repeated once.
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test13()
    {
        Assert.Equal("SSttrriinngg", Method13("String"));
        Assert.Equal("HHeelllloo  WWoorrlldd!!", Method13("Hello World!"));
        Assert.Equal("11223344!!__  ", Method13b("1234!_ "));
    }
    /// <summary>
    /// Takes a number as an argument and returns "Fizz", "Buzz" or "FizzBuzz".
    /// </summary>
    /// <returns></returns>

    [Fact]
    public void Test12()
    {
        Assert.Equal("Fizz", Method12(3));
        Assert.Equal("Buzz", Method12(5));
        Assert.Equal("FizzBuzz", Method12(15));
        Assert.Equal("4", Method12(4));
    }
    /// <summary>
    /// Create a function that converts a date formatted as MM/DD/YYYY to YYYYDDMM.
    /// </summary>
    /// <returns>A String</returns>
    [Fact]
    public void Test11()
    {
        Assert.Equal("20191211", Method11("11/12/2019"));
        Assert.Equal("20193112", Method11b("12/31/2019"));
        Assert.Equal("20191501", Method11c("01/15/2019"));
    }
    /// <summary>
    /// Removes the first and last characters from a string.
    /// </summary>
    /// <returns>If the string is 2 or fewer characters long, return the string itself.</returns>

    [Fact]
    public void Test10()
    {
        Assert.Equal("ell", Method10("Hello"));
        Assert.Equal("ayb", Method10("Maybe"));
        Assert.Equal("enefi", Method10b("Benefit"));
        Assert.Equal("a", Method10("a"));
    }
    /// <summary>
    /// Counts how many D's are in a sentence
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [Fact]
    public void Test9()
    {
        Assert.Equal(4, Method9("My friend Dylan got distracted in school."));
        Assert.Equal(3, Method9("Debris was scattered all over the yard."));
        Assert.Equal(3, Method9("The rodents hibernated in their den."));
    }
    /// <summary>
    /// Returns true if an input string contains only uppercase or only lowercase letters.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>

    [Fact]
    public void Test8()
    {
        Assert.True(Method8("hello"));
        Assert.True(Method8("HELLO"));
        Assert.False(Method8("Hello"));
        Assert.False(Method8("ketcHUp"));
    }
    /// <summary>
    /// Return how many claps are in a sentance
    /// </summary>
    /// <param name="claps"></param>
    /// <returns></returns>
    [Fact]
    public void Test7()
    {
        Assert.Equal(4, Method7("ClaClaClaClap!"));
        Assert.Equal(6, Method7("ClClClaClaClaClap!"));
        Assert.Equal(9, Method7("CCClaClClap!Clap!ClClClap!"));
    }
    /// <summary>
    /// Computes the number of characters that differ between two strings.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>

    [Fact]
    public void Test6()
    {
        Assert.Equal(0, Method6("abcde", "abcde"));
        Assert.Equal(1, Method6("abcde", "absde"));
        Assert.Equal(2, Method6b("abmcdz", "abmsdq"));
        Assert.Equal(5, Method6b("abcde", "bcdef"));
    }
    /// <summary>
    /// Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    [Fact]
    public void Test5()
    {
        int[] testArray = { 1, -2, 3, -4, 5 };
        Assert.Equal(15, Method5(testArray));
    }
    /// <summary>
    /// Returns the smaller number of two strings
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    [Fact]
    public void Test4()
    {
        Assert.Equal("5", Method4("5", "6"));
        Assert.Equal("5", Method4("6", "5"));
        Assert.Equal("9078", Method4b("107838", "9078"));
        Assert.Equal("9078", Method4b("107838", "9078"));
    }
    /// <summary>
    /// Takes an array of numbers and return both the minimum and maximum numbers
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    [Fact]
    public void Test3()
    {
        int[] a = { 1, 50 };
        int[] b = { 6, 1, 45, 50 };
        Assert.Equal(a, Method3(b));
        int[] c = { -99, 209 };
        int[] d = { 3, 54, -99, 209, 34, 75, -3, -45 };
        Assert.Equal(c, Method3b(d));
    }
    /// <summary>
    /// Returns true if all characters in a string are identical
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [Fact]
    public void Test2()
    {
        Assert.True(Method2("aaaaa"));
        Assert.False(Method2b("aaabaaa"));
        Assert.False(Method2c("mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmn"));
        Assert.False(Method2c("nmmmmmmmmm"));
        Assert.True(Method2c("z"));
    }

    /// <summary>
    /// Takes a number (from 1 to 12) and returns its corresponding month name as a string
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    [Fact]
    public void Test1()
    {
        Assert.Equal("April", Method1(4));
        Assert.Equal("November", Method1(11));
        Assert.Equal("December", Method1(12));
        Assert.Equal("Not on the Calendar", Method1(13));
    }
}