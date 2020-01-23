/*-----------------------------------------------------------------------
	Garrett Gulker
	Assignment 1
	Parallel V2

	Instructions for Stampede2:
	1. Place this file and "GulkerParallelV2Script" in your Stampede2 files using WinScp

	2. Open the putty command window and connect to Stampede2

	3. Type "mpicc GulkerParallelV2.c -o ParallelV2.exe" into your putty console

	4. Type "sbatch GulkerParallelV2Script" into your putty console

	5. Open Parallel.o# to find the output of the code
-----------------------------------------------------------------------*/

#include <stdio.h>
#include <mpi.h>     /* For MPI functions, etc */ 

// how large our main array is
const int ARRAY_SIZE = 640000;

int main(void)
 {
   int        comm_sz;               /* Number of processes    */
   int        my_rank;               /* My process rank        */
   /* Start up MPI */
   MPI_Init(NULL, NULL); 

   /* Get the number of processes */
   MPI_Comm_size(MPI_COMM_WORLD, &comm_sz); 

   /* Get my rank among all the processes */
   MPI_Comm_rank(MPI_COMM_WORLD, &my_rank); 
   
   //the size of each processes section
   const long int SECTION_SIZE = ARRAY_SIZE / comm_sz;
   long int section[SECTION_SIZE], mainArray[ARRAY_SIZE];
   long int localTotal = 0, total = 0, i;
   double startTime, endTime, totalTime;

   //fill main array with numbers
   if (my_rank == 0) 
   { 
	   for (i = 0; i < ARRAY_SIZE; i++)
		   mainArray[i] = i + 1;
   } 

   startTime = MPI_Wtime();//start timer
	//share even sections of array with each process
   MPI_Scatter(&mainArray, SECTION_SIZE, MPI_LONG, &section, SECTION_SIZE, MPI_LONG, 0, MPI_COMM_WORLD);

   //summation of procceses array
   for (i = 0; i < SECTION_SIZE; i++)
   {
	   localTotal += section[i];
   }

   //add all summations together and give to process 0
   MPI_Reduce(&localTotal, &total, 1, MPI_LONG, MPI_SUM, 0, MPI_COMM_WORLD);
   endTime = MPI_Wtime();//end timer

   if (my_rank == 0)
   {
	   totalTime = (endTime - startTime) * 1000000;
	   printf("The summation of all numbers is: %ld\n", total);
	   printf("Time to complete: %f microseconds\n", totalTime);
   }

   /* Shut down MPI */
   MPI_Finalize(); 

   return 0;
}  /* main */
