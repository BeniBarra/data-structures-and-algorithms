## array-insert-shift
Given an Array, and a Value </br>
Return an array with the given value inserted in the middle index of the returned array

## Whiteboard Process
- Created by Benjamin Ibarra & Jona Brown
- We detailed a `problem domain` specifying the requirements of the challenge
- Then Made a `Visual` representation of the array value swapping
- Roughed out the steps for our `algorithm`
- Wrote out `Pseudo code` detailing in plain-ish english our codes intended structure and behavior
- Outlined steps to `verify` our solution and test possible edge cases

## Approach & Efficiency
- Create a new Array that is 1 index value longer than the original array,
- create a loop that will iterate and insert the given array values until it reachs the middle index value
- the First loop breaks, and we insert the given value into the middle index position
- start a new loop that will insert the remaining values into rest of the new array
- return the new array with desired ouput
- Our approach was to make try and make this a linear method

![array-reversed](./array-insert-shift(2).png)
