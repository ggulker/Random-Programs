/*-----------------------------------------------------------------------
	Garrett Gulker
	Assignment 1
	Parallel V1

	Instructions for Stampede2:
	1. Place this file and "GulkerParallelV1Script" in your Stampede2 files using WinScp

	2. Open the putty command window and connect to Stampede2

	3. Type "mpicc GulkerParallelV1.c -o ParallelV1.exe" into your putty console

	4. Type "sbatch GulkerParallelV1Script" into your putty console

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

   // how large an array each process gets
   const int SECTION_SIZE = ARRAY_SIZE / comm_sz;

   if (my_rank == 0) 
   { 
		//create the main array
		long int mainArray[ARRAY_SIZE];
		long int i,p;
		double startTime, endTime, totalTime;
		//fill array
		for(i = 0; i < ARRAY_SIZE; i++)
		{
			mainArray[i] = i+1;
		}
		
		//send array sections to each process
		for(p = 1; p < comm_sz; p++)
		{
			long int start = p*SECTION_SIZE;
			startTime = MPI_Wtime();//start timer
			//send the section to its process
			MPI_Send(&mainArray[start], SECTION_SIZE, MPI_LONG, p, 0, MPI_COMM_WORLD);
		}
		
		//create array that holds summations
		long int summations[comm_sz];

		//find process zero local total  place in summation array
		long int localTotal = 0;
		for(i = 0; i < SECTION_SIZE; i++)
		{
			localTotal += mainArray[i];
		}
		summations[0] = localTotal;

		//recieve the summations from each process
		for(p = 1; p <comm_sz; p++)
		{
			long int processTotal = 0;
			MPI_Recv(&processTotal, 1, MPI_LONG, p, 1, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
			//place each process total in the summations array
			summations[p] = processTotal;
		}
		
		//calculate and print a total
		long int total = 0;
		for(i = 0; i < comm_sz; i++)
		{
			total+= summations[i];
		}
		endTime = MPI_Wtime();//end timer


		totalTime = (endTime - startTime) * 1000000;
		printf("The summation of all numbers is: %ld\n",total);
		printf("Time to complete: %f microseconds\n", totalTime);
   } 
   else 
   {  
		long int local_section[SECTION_SIZE];
		long int i;
		//recieve our array section from process 0
		MPI_Recv(local_section, SECTION_SIZE, MPI_LONG, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
		
		//find summation of array section
		long int local_total = 0;
		for (i = 0; i < SECTION_SIZE; i++)
		{
			local_total += local_section[i];
		}

		//return summation back to process 0
		MPI_Send(&local_total,1, MPI_LONG, 0,1,MPI_COMM_WORLD);
   } 


   /* Shut down MPI */
   MPI_Finalize(); 

   return 0;
}  /* main */
