// Task 7 . 1
/* var nums = new List<int>(){1, 0, 5, -4, 5, 10 ,-80, 24, 0, -4, 100, 24, 45, 6, -1};
int max=nums[0];
foreach (var item in nums)
{
    if (max < item)
    {
        max = item;
    }
}
System.Console.4WriteLine(max); */

// Task 7 . 2
/* int cnt=0;
var nums = new List<int>(){1, 0, 5, -4, 5, 10 ,-80, 24, 0, -4, 100, 24, 45, 6, -1};
nums.RemoveAll(x=>(x==x));
foreach (var item in nums)
{
    System.Console.Write($"{item} ");
} */


// Task 7 . 3
/* var nums = new List<int>(){1, 0, 5, -4, 5, 10 ,-80, 24, 0, -4, 100, 24, 45, 6, -1};
nums.Sort();
foreach (var item in nums)
{
    System.Console.Write(item + " ");
} */

// Task 7 . 4 
/* var nums = new List<int>(){1, 0, 5, -4, 5, 10 ,-80, 24, 0, -4, 100, 24, 45, 6, -1};
int cnt=0;
foreach (var item in nums)
{
    if (item < 0)
    {
        cnt=item;
        
    }

    if (cnt < 0)
    {
        cnt=0;
        System.Console.Write($"{item} ");
    }
} */
