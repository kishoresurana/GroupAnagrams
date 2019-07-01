# GroupAnagrams

When working on the below Anagrams leetcode question, my first solution to identify if 2 words are an anagram, is to do the following:
1. For each input word, count the number of occurences of each character and store them in a HashTable<char, int>
2. To determine if the 2 words are an anagram, compare the hashtables of the words, to see if they exactly match - the characters and the number of occurences of each character

An alternate (simpler) solution is to:
1. Sort the string to its root word. For instance, the input words 'eat' and 'tea' would reduce to the same root word 'aet'.
2. To determine if the 2 words are an anagram, simply check if the root word (i.e. sorted word) of each of the input words is identical.
This alternate solution, although is cleaner to implement, does incur an additional sort in terms of performance.

**See code in Program.cs file.**

Leetcode question: https://leetcode.com/problems/group-anagrams/
    Given an array of strings, group anagrams together.

    Example:

    Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
    Output:
    [
      ["ate","eat","tea"],
      ["nat","tan"],
      ["bat"]
    ]
    Note:

    All inputs will be in lowercase.
    The order of your output does not matter.
