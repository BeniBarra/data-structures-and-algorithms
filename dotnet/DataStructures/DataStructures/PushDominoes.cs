using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class PushDominoes
  {
    public static string DominoeEffect(string dominoes)
    {
      //convert the string into an arr of char
      char[] domArr = dominoes.ToArray();

      //instantiate variable k to trace behind i within forloop
      int k = 0;
      //instantiate a counter to keep track of dominoes falling to the right
      int rCounter = 0;

      for(int i = 0;  i < domArr.Length; i++)
      {
        // To make k trace behind i, it is only incremented after i > 1
        if(i > 1) { k++; }

        // Since only dominoes falling to 'L' can effect the start of our array, we begin checking for 'L'
        if(domArr[i] == 'L' && domArr[k] == '.') { domArr[k] = 'L'; }
        // If we come across an new instance of 'R' within a 'R' collapsing section of dominoes
        // we must reset the rCounter, to calculate the proper center point
        // of a 'R' & 'L' dominoe balance
        else if (domArr[i] == 'R')
        {
          rCounter = 0;
        }

        // Secondly we start looking for if i == '.'
        // Because if tracing K == 'R', then the period will be affected by it
        if(domArr[i] == '.' && domArr[k] == 'R')
        {
          domArr[i] = 'R';
          // Since we've started altering '.' to 'R', rCounter++ tracks the '.' to 'R' conversions
          rCounter++;
        }



        // This checks for the condition where 'R' collapses to 'L'
        // in order to find the balance of the dominoes
        else if(domArr[k] == 'R' && domArr[i] == 'L')
        {
          if(rCounter == 0)
          {
            //Do nothing to maintain the '.' between a (R . L) dominoe section
          }
          // if rCounter is even, do:
          else if(rCounter % 2 == 0)
          {
            int j = i - (rCounter / 2);
            while (j != i)
            {
              domArr[j] = 'L';
              j++;
            }
          }
          // rCounter is odd, do:
          else
          {
            int j = i - ((rCounter / 2) + 1);
            domArr[j] = '.';
            j++;
            while (j != i)
            {
              domArr[j] = 'L';
              j++;
            }
          }
          rCounter = 0;
        }
      }
      // Convert the array back to a string and return them
      string result = string.Empty;
      foreach(char dom in domArr)
      {
        result += dom;
      }
      return result;
    }
  }
}
