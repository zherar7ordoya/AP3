/**
 * COMPILAR: gcc video3.c -o video3
 * EJECUTAR: ./video3 (Ubuntu) video3 (Windows)
*/

#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>

int main(int argc, char * argv[])
{
    pid_t pid;
    int n = atoi(argv[1]);
    int i;
    for(i=0; i<n; i++)
    {
        pid = fork();
        if (pid>0) break;
    }
    printf("Padre %d saliendo. Creó el hijo %d", getpid(), pid);
    exit(0);
}