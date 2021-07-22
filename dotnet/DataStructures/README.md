# Singly Linked List
Created a solution that can generate a singly link list, with a method to display the list to console

## Challenge
Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.

## Approach & Efficiency
Using an O(1) method, a singly linked list can be created from given values and displayed to console

## API
- Class LinkedList
    - LinkedList()
    - Insert()
    - Includes()
    - Print()  

## Code Challenge 06 `link-list-insertion`

append:
- arguments: new value
- adds a new node with the given value to the end of the list  

insert before:
- arguments: value, new value
- adds a new node with the given new value immediately before the first node that has the value specified

insert after:
- arguments: value, new value
- badds a new node with the given new value immediately after the first node that has the value specified  


## Approach & Efficiency
![link-list-insertion](./challenge/link-list-insertion.png)

## Code Challenge 07 `link-list-kth`

### kth from end
argument: a number, k, as a parameter.
Return the node’s value that is k places from the tail of the linked list.
You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.


## Approach & Efficiency
![link-list-kth](./challenge/linked-list-kth.png)

## Code Challenge 08 `link-list-zip`

### Zip two linked list
Write a function that takes in 2 lists as arguments  
Zip the two linked lists together into one so that the nodes alternate between the two lists and return a reference to the head of the zipped list.

## Approach & Efficiency
![link-list-kth](./challenge/linked-list-zip.png)
