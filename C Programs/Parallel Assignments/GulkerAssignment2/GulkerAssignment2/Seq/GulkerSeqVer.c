//********************************************************
// Assignment 2
// Name: Garrett Gulker
// Parallel Programming Date: (10/31/19)
//********************************************************
// This program computes an FFt algorithm for N coefficients
// with a given first 8 complex values. This program is
// specifically in sequential form and timed to see how long
// it takes to compute large values of N.
//********************************************************
// even
// parameters: complex double data[], int n, int k
// Desc : computes the even side of a FFT algorithm given
// the array of real and imaginary numbers, a N value,
// and a coefficient value
//********************************************************
// odd
// parameters: complex double data[], int n, int k
// Desc : computes the odd side of a FFT algorithm given
// the array of real and imaginary numbers, a N value,
// and a coefficient value
//********************************************************

#include <stdio.h>
#include <complex.h>
#include <math.h>
#include <time.h>
#include <sys/time.h>

double TWO_PI = M_PI*2; 
complex double even(complex double data[], int n,int k);
complex double odd(complex double data[], int n,int k);

int main(void) 
{
  //the amount of given samples
  const int n =1024;

  //used for loops
  int i,x;

  //holds the answers to a corresponding coefficient
  complex double ans[n];

  //holds even and odd values returned
  complex double e,o;

  //holds time of our compilation
  struct timeval start, end;
  double timeTotal = 0;

  //print top of our output
  printf("TOTAL PROCESSED SAMPLES: %d\n", n);
  printf("==================================\n");

  //create and fill complex array of given values
  //all other values result in 0
  complex double data[n];
  data[0] = 3.6 + 2.6 * I;
  data[1] = 2.9 + 6.3 * I;
  data[2] = 5.6 + 4 * I;
  data[3] = 4.8 + 9.1 * I;
  data[4] = 3.3 + .4 * I;
  data[5] = 5.9 + 4.8 * I;
  data[6] = 5 + 2.6 * I;
  data[7] = 4.3 + 4.1 * I;
  for(i = 8; i < n; i++)
  {
    data[i] = 0;
  }

  //compute 3 times to get an average time
  for(x = 0; x < 3; x++)
  {
    gettimeofday(&start, NULL); //start of timer
    
    //compute FFT for k and k+n/2 for all k < n/2
    for(i = 0; i < n/2; i++)
    {
      e = even(data, n, i);
      o = odd(data, n, i);
      //algorithm can be used to fill two locations
      ans[i] = e + o;
      ans[i + n/2] = e - o;
    }

    gettimeofday(&end, NULL);//end of timer
    timeTotal+=(end.tv_sec * 1000000 + end.tv_usec)
		  - (start.tv_sec * 1000000 + start.tv_usec);
  }

  //print all results
  for(i = 0; i < n; i++)
  {
    printf("XR[%d]: %g   XI[%d]: %g\n", i, creal(ans[i]), i, cimag(ans[i]));
    printf("==================================\n");
  }
  
  //prints average of all times
  timeTotal /= 3;
  printf("AVERAGE TIME: %f microseconds\n",timeTotal );
}

complex double even(complex double data[], int n,int k)
{
  int i;
  //used to return
  complex double ret = 0;
  //computes and adds all even values for given k
  for(i = 0; i < n/2; i++)
  {
    ret += data[2*i]*(ccos(TWO_PI * k * (2*i)/n)-I*csin(TWO_PI * k * (2*i)/n));
  }
  return ret;
}

complex double odd(complex double data[], int n, int k)
{
  int i;
  //used to return
  complex double ret = 0;
  //computes and adds all odd values for given k
  for(i = 0; i < n/2; i++)
  {
    ret += data[2*i+1]*(ccos(TWO_PI * k * (2*i+1)/n)-I*csin(TWO_PI * k * (2*i+1)/n));
  }
  return ret;
}