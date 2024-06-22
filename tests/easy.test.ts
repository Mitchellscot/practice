import {describe, expect, test} from '@jest/globals';
import { twoSum } from "../LeetCode/easy";

describe("twoSum", () => {
    test('should return [0, 1] for nums = [2, 7, 11, 15], target = 9', () => {
        const nums = [2, 7, 11, 15];
        const target = 9;
        expect(twoSum(nums, target)).toEqual([0, 1]);
    });
});