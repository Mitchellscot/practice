import {describe, expect, test} from '@jest/globals';
import { twoSum_0, twoSum_1 } from "../LeetCode/easy";

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