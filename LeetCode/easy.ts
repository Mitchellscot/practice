//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
export const twoSum_0 = (nums: number[], target: number): number[] => {
    if(nums.length == 0)
        return [0,0];
    
    for (let i = 0; i < nums.length; i++)
    {
        for (let j = i + 1; j < nums.length; j++)
        {
            if(nums[j] + nums[i] == target)
                return [i, j];
        }
    }
    return [0,0];
};

export const twoSum_1 = (nums: number[], target: number): number[] => {
    if(nums.length == 0)
        return [0,0];

    let seen = new Map();
    for (let i = 0; i < nums.length; i++)
    {
        let diff = target - nums[i];
        if(seen.has(diff))
            return [seen.get(diff), i];
        else
            seen.set(nums[i], i);
    }
    return [0,0];
};

export const IsPalindrome_1 = (n: number): Boolean =>
{
    if(n < 0 || (n % 10 == 0 && n != 0))
        return false;

    let revertedNumber = 0;

    while (n > revertedNumber)
    {
        revertedNumber = revertedNumber * 10 + n % 10;
        n /= 10;
    }
    return n == revertedNumber || n == revertedNumber / 10;
}