//********************************************************
// Assignment 2
// Name: Garrett Gulker
// Parallel Programming Date: (10/31/19)
//********************************************************
// This program computes an FFt algorithm for N coefficients
// with a given first 8 complex values. This program is
// specifically in parallel form and timed to see how long
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
#include <mpi.h>

double TWO_PI = M_PI*2; 
complex double even(complex double data[], int n,int k);
complex double odd(complex double data[], int n,int k);

int main(int argc, char* argv[]) 
{
  int rank, size;
  //the amount of given samples
  const int n =1024;

  //used for loops
  int i,x,y;

  //holds the answers to a corresponding coefficient
  complex double ans[n];

  //holds gather results
  complex double fans[n];
  complex double gans[n];

  //holds even and odd values returned
  complex double e,o;

  MPI_Init (&argc, &argv);      /* starts MPI */
  MPI_Comm_rank (MPI_COMM_WORLD, &rank);        /* get current process id */
  MPI_Comm_size (MPI_COMM_WORLD, &size);        /* get number of processes */

  //create complex array
  complex double data[n];

  //the amount of coefficients each process deals with
  int procSize = (n/size)/2;

  //holds all time values
  double startTime, endTime, totalTime = 0;


  if(rank == 0)
  {
    //print top of our output
    printf("TOTAL PROCESSED SAMPLES: %d\n", n);
    printf("==================================\n");
  }

  //fill array with given tableand zeros
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
  
  //run 3 times to determine time average
  for(y = 0; y < 3; y++)
  {
	startTime = MPI_Wtime();//start timer
    //calculate each k and k+n/2 in one loop
    for(i = procSize*rank; i < procSize+(procSize*rank); i++)
    {
      e = even(data, n, i);
      o = odd(data, n, i);
      //algorithm can be used to fill two locations
      ans[i] = e + o;
      ans[i + n/2] = e - o;
    }
	endTime = MPI_Wtime();//end timer
	totalTime += (endTime - startTime)*100000;
  }

  //gathers both all solved k and k+n/2 values
  MPI_Gather(&ans[rank*procSize], procSize*2,MPI_COMPLEX, &fans[rank*procSize], procSize*2, MPI_COMPLEX, 0, MPI_COMM_WORLD);
  MPI_Gather(&ans[rank*procSize+n/2], procSize*2,MPI_COMPLEX, &gans[rank*procSize+n/2], procSize*2, MPI_COMPLEX, 0, MPI_COMM_WORLD);
  

  if(rank == 0)
  {
    //print all results
    for(i = 0; i < n/2; i++)
    {
      printf("XR[%d]: %g   XI[%d]: %g\n", i, creal(fans[i]), i, cimag(fans[i]));
      printf("==================================\n");
    }
	
    for(i = n/2; i < n; i++)
    {
      printf("XR[%d]: %g   XI[%d]: %g\n", i, creal(gans[i]), i, cimag(gans[i]));
      printf("==================================\n");
    }
	
	printf("AVERAGE TIME: %f microseconds\n",totalTime/3);
  }
  
  MPI_Finalize();
  return 0;
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