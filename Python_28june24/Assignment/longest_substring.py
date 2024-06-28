def longest_unique_substring(s):
    seen = {}
    start = 0
    max_length = 0
    max_substr = ""

    for end in range(len(s)):
        if s[end] in seen and seen[s[end]] >= start:
            start = seen[s[end]] + 1
        seen[s[end]] = end
        if end - start + 1 > max_length:
            max_length = end - start + 1
            max_substr = s[start:end + 1]

    return max_substr

# Example usage:
string = "abcabcbb"
print(longest_unique_substring(string))  # Output: "abc"
