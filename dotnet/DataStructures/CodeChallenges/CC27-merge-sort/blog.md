# Merge Sort
### Take the example pseudo code below, and detail step by step the way in which it will merge and sort an array of numbers

```
ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length

    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1

        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left
```
![merge-sort](./merge-sort.png)

#### Rough Steps
- MergeSort first splits the base array in half. Each half is assign to variable:
    - left = first half of base array
    - right = second half of base array
- The left and right array are continued to be split through recursion,
- Since MergeSort takes in an array, and while it's possible splits the array in half and assigns the halfs to new right and left arrays.
- This is accomplished by calling MergeSort( left ) & MergeSort( right )
- Once all instances of left and right arrays only contain 1 value
- our Merge method begins to compare and sort the numbers in order, "Merge(left, right)"
- Now that each instance of right and left are in order, we compare each unit to the other once again to establish proper order, returning the final properly merged and ordered array

