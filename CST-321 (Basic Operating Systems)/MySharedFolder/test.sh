#!/bin/sh
echo "Showing All Files in Directory.."
ls
echo "Peaking At the First Three Lines in Groceries.txt"
head -3 Groceries
echo "Searching For Any String that Contains 'a'"
grep -c a Groceries
echo "Redirecting Next Output to test.txt"
grep a Groceries > test.txt
echo "Previewing test.txt"
cat test.txt