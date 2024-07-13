import {describe, expect, test} from '@jest/globals';
import { twoSum_0, twoSum_1, IsPalindrome_1, RomanToInt } from "../LeetCode/easy";

describe("twoSum_1", () => {
    test('should return [0, 1] for nums = [2, 7, 11, 15], target = 9', () => {
        const nums = [2, 7, 11, 15];
        const target = 9;
        expect(twoSum_1(nums, target)).toEqual([0, 1]);
    });
    test('should return [1, 2] for nums = [3, 2, 4], target = 6', () => {
        const nums = [3, 2, 4];
        const target = 6;
        expect(twoSum_1(nums, target)).toEqual([1, 2]);
    });
    test('should return [0, 1] for nums = [3, 3], target = 6', () => {
        const nums = [3, 3];
        const target = 6;
        expect(twoSum_1(nums, target)).toEqual([0, 1]);
    });
    test('should return [0, 2] for nums = [3, 2, 3], target = 6', () => {
        const nums = [3, 2, 3];
        const target = 6;
        expect(twoSum_1(nums, target)).toEqual([0, 2]);
    });
});

describe("twoSum_0", () => {
    test('should return [0, 1] for nums = [2, 7, 11, 15], target = 9', () => {
        const nums = [2, 7, 11, 15];
        const target = 9;
        expect(twoSum_0(nums, target)).toEqual([0, 1]);
    });
    test('should return [1, 2] for nums = [3, 2, 4], target = 6', () => {
        const nums = [3, 2, 4];
        const target = 6;
        expect(twoSum_0(nums, target)).toEqual([1, 2]);
    });
    test('should return [0, 1] for nums = [3, 3], target = 6', () => {
        const nums = [3, 3];
        const target = 6;
        expect(twoSum_0(nums, target)).toEqual([0, 1]);
    });
    test('should return [0, 2] for nums = [3, 2, 3], target = 6', () => {
        const nums = [3, 2, 3];
        const target = 6;
        expect(twoSum_0(nums, target)).toEqual([0, 2]);
    });
    
});

describe("isPalindrome_1", () => {
    test('should return true for 121', () => {
        const n = 121;
        expect(IsPalindrome_1(n)).toEqual(true);
    });
    test('should return false for -121', () => {
        const n = -121;
        expect(IsPalindrome_1(n)).toEqual(false);
    });
    test('should return false for 10', () => {
        const n = 10;
        expect(IsPalindrome_1(n)).toEqual(false);
    });
    test('should return true for 0', () => {
        const n = 0;
        expect(IsPalindrome_1(n)).toEqual(true);
    });
});

describe("RomanToInt", () => {
    test('should return 3 for III', () => {
        const s = "III";
        expect(RomanToInt(s)).toEqual(3);
    });
    test('should return 4 for IV', () => {
        const s = "IV";
        expect(RomanToInt(s)).toEqual(4);
    });
    test('should return 9 for IX', () => {
        const s = "IX";
        expect(RomanToInt(s)).toEqual(9);
    });
    test('should return 58 for LVIII', () => {
        const s = "LVIII";
        expect(RomanToInt(s)).toEqual(58);
    });
    test('should return 1994 for MCMXCIV', () => {
        const s = "MCMXCIV";
        expect(RomanToInt(s)).toEqual(1994);
    });
});