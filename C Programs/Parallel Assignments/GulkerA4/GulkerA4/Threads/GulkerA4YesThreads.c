//-------------------------------------------------
//  Garrett Gulker
//-------------------------------------------------
//  Compilation Instruction:
//  icc GulkerA4YesThreads.c -o Threads.exe -lpthread
//-------------------------------------------------
//  Execution Instruction:
//  sbatch YesThreadsScript
//-------------------------------------------------
#include <stdio.h>
#include <pthread.h>
#include <time.h>
#include <sys/time.h>

//number of threads being used
#define NUM_THREADS 4

//how large our arrays will be
#define size 1000000

//will be used to send each thread our info
struct thread_data
{
  short int a[size];
  short int b[size];
};

//functions precompiled headers
void *addition(void *threadarg);
void *subtraction(void *threadarg);
void *multiplication(void *threadarg);
void *division(void *threadarg);

int main(void) {
  int long i;
  int add,sub,mult,div;
  //holds all our threads
  pthread_t threads[NUM_THREADS];
  int *taskids[NUM_THREADS];

  //struct used for data
  struct thread_data data;

  //time management variables
  struct timeval start, end;
  double timeTotal = 0;

  //fill both arrays
  for(i = 0; i < size; i++)
  {
    data.a[i] = 1;
    data.b[i] = 2;
  }

  gettimeofday(&start, NULL);//start timer

  //create all four threads and send to routines
  add = pthread_create(&threads[0], NULL, addition, (void *)&data);
  sub = pthread_create(&threads[1], NULL, subtraction, (void *)&data);
  mult = pthread_create(&threads[2], NULL, multiplication, (void *)&data);
  div = pthread_create(&threads[3], NULL, division, (void *)&data);

  //waits for all threads to terminate before timing
  pthread_join(threads[0], NULL);
  pthread_join(threads[1], NULL);
  pthread_join(threads[2], NULL);
  pthread_join(threads[3], NULL);

  gettimeofday(&end, NULL);//end timer

  //calculate and print time
  timeTotal +=(double)(end.tv_sec + end.tv_usec) - (start.tv_sec + start.tv_usec);
  printf("TIME IN SECONDS: %f\n",timeTotal/1000000);
  pthread_exit(NULL);

  return 0;
}


//add together given arrays in new array
void *addition(void *threadarg)
{
  long int i;
  //new array to place into
  short int add[size];
  //create new struct
  struct thread_data *my_data;
  //pass given struct
  my_data = (struct thread_data *) threadarg;

  for(i = 0; i < size; i++)
  {
    add[i] = my_data->a[i] + my_data->b[i];
  }

  pthread_exit(NULL);
}

//subtract given arrays from another and place in new array
void *subtraction(void *threadarg)
{
  long int i;
  short int subtract[size];
  struct thread_data *my_data;
  my_data = (struct thread_data *) threadarg;

  for(i = 0; i < size; i++)
  {
    subtract[i] = my_data->a[i] - my_data->b[i];
  }

  pthread_exit(NULL);
}

//sum of two given arrays and placed into new array
void *multiplication(void *threadarg)
{
  long int i;
  short int multiply[size];
  struct thread_data *my_data;
  my_data = (struct thread_data *) threadarg;

  for(i = 0; i < size; i++)
  {
    multiply[i] = my_data->a[i] * my_data->b[i];
  }

  pthread_exit(NULL);
}

//divide two given arrays from another and place in new array
void *division(void *threadarg)
{
  long int i;
  double divide[size];
  struct thread_data *my_data;
  my_data = (struct thread_data *) threadarg;

  for(i = 0; i < size; i++)
  {
    divide[i] = my_data->a[i] / my_data->b[i];
  }

  pthread_exit(NULL);
}