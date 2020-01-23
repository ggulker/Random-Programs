/*-----------------------------------------------------------------------
	Garrett Gulker
	Assignment 1
	Serial Code

	Instructions for Stampede2:
	1. Place this file and "GarrettGulkerSerialScript" in your Stampede2 files using WinScp
	
	2. Open the putty command window and connect to Stampede2

	3. Type "mpicc GarrettGulkerSerial.c -o Serial.exe" into your putty console

	4. Type "sbatch GarrettGulkerSerialScript" into your putty console

	5. Open Serial.o# to find the output of the code
-----------------------------------------------------------------------*/

#include <stdio.h>
#include <time.h>
#include <sys/time.h>
#define ARRAY_MAX 640000

int main(void) {
  int arr[ARRAY_MAX];
  struct timeval start, end;
  long int total = 0;

  //fill main array with numbers
  for(int i = 0; i < ARRAY_MAX; i++)
  {
    arr[i] = i+1;
  }

  //sum array and collect time
  gettimeofday(&start, NULL); //start of timer
  for(int i = 0; i < ARRAY_MAX; i++)
  {
    total += arr[i];
  }
  gettimeofday(&end, NULL);//end of timer

  //print out time and total
  printf("The summation of all numbers is: %ld\n", total);
  printf("Time to complete: %ld microseconds\n", ((end.tv_sec * 1000000 + end.tv_usec)
		  - (start.tv_sec * 1000000 + start.tv_usec)));
  return 0;
}