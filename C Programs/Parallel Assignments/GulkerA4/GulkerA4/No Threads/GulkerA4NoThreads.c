//-------------------------------------------------
//  Garrett Gulker
//-------------------------------------------------
//  Compilation Instruction:
//  gcc GulkerA4NoThreads.c -o NoThreads.exe
//-------------------------------------------------
//  Execution Instruction:
//  sbatch NoThreadsScript
//-------------------------------------------------
#include <stdio.h>
#include <time.h>
#include <sys/time.h>

//size of all our arrays
#define size 1000000

//precompile headers for all our functions
void addition(short int a[],short  int b[]);
void subtraction(short int a[], short int b[]);
void multiplication(short int a[], short int b[]);
void division(short int a[], short int b[]);

int main(void) {
  int i;
  //holds time values
  struct timeval start, end;
  double timeTotal = 0;

  //arrays of data
  short int a[size];
  short int b[size];

  //fill arrays with 1's and 2's
  for(i = 0; i < size; i++)
  {
    a[i] = 1;
    b[i] = 2;
  }

  gettimeofday(&start, NULL);//start timer

  //run all four functions to time
  addition(a, b);
  subtraction(a, b);
  multiplication(a, b);
  division(a, b);
  
  gettimeofday(&end, NULL);//end timer

  //compute and print time
  timeTotal +=(double)(end.tv_sec + end.tv_usec) - (start.tv_sec + start.tv_usec);
  printf("TIME IN SECONDS: %f\n",timeTotal/1000000);

  return 0;
}

//adds all values of two given 'size' large arrays
void addition(short int a[], short int b[])
{
  int i;
  short int addition[size];
  for(i = 0; i < size; i++)
  {
    addition[i] = a[i] + b[i];
  }

  return;
}

//subtracts all values of two given 'size' large arrays
void subtraction(short int a[], short int b[])
{
  int i;
  short int sub[size];
  for(i = 0; i < size; i++)
  {
    sub[i] = a[i] - b[i];
  }
  return;
}

//multiplies all values of two given 'size' large arrays
void multiplication(short int a[], short int b[])
{
  int i;
  short int multi[size];
  for(i = 0; i < size; i++)
  {
    multi[i] = a[i] * b[i];
  }
  return;
}

//divides all values of two given 'size' large arrays 
void division(short int a[], short int b[])
{
  long int i;
  double divide[size];
  for(i = 0; i < size; i++)
  {
    divide[i] = (double)a[i] / b[i];
  }
  return;
}