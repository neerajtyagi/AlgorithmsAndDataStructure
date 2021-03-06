## Problem: Average weight on bridge at a given time

Given a long bridge which is used only by trucks, we weigh each truck as it enters the bridge and record its entry time and exit time.
Assume all entries are rounded off to the nearest hour and are between 0000 hour and 2400 hour.

The entries are provided as 2D Array where each row corresponds to a new entry.
0900 1200 200

The first column provides the entry time, the second column the exit time and the last column provides the weight of the truck.
In the table above, the entry time is 0900, exit time is 1200 and weight is 200.

Given a list of such entries, determine the average weight on the bridge at any given time.


### Entries -
1. 0900 1200 200
2. 1100 1300 500
3. 1000 1200 200
4. 1400 1600 1100

### Results
- At Time = 1000 Output: 200 (Explanation - both 1 and 3 are on the bridge)
- At Time = 1100 Output: 300 [Explanation - 3 trucks are on the bridge at that time]