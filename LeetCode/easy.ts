//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
export const twoSum = (nums: number[], target: number): number[] => {
    if (nums.length === 0) 
        return [];
    
    for (let i = 0; i < nums.length; i++) {
        if (i == nums.length - 1)
            return [0, 0];
        else if (nums[i] + nums[i + 1] == target)
            return [i, i + 1];
    }
    return [0, 0];
};