# 193. Valid Phone Numbers
# https://leetcode.com/problems/valid-phone-numbers
# by Equim on 17-03-05

# Read from the file file.txt and output all valid phone numbers to stdout.
cat file.txt | grep -P "^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$"