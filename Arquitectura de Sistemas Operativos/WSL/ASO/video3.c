#include <sys/types.h>
#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>


int main(int argc, int argv[])
{
    pid_t pid;
    int n = argv[1];
    int i;
    for(i=0; i<n; i++)
    {
        pid = fork();
        if (pid>0) break;
    }
    printf("Padre %d saliendo. Creó el hijo %d\n", getpid(), pid);
    exit(0);
}